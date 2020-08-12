using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TerminalMKAspNetBot.Models;

namespace TerminalMKAspNetBot.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")] //webhook uri part
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();


            switch (message.Type)
            {
                case MessageType.Text:
                    // Echo each Message
                    await client.SendTextMessageAsync(message.Chat.Id, message.Text);
                    break;

                case MessageType.Photo:
                    // Download Photo
                    var fileId = message.Photo.LastOrDefault()?.FileId;
                    var file = await client.GetFileAsync(fileId);

                    var filename = file.FileId + "." + file.FilePath.Split('.').Last();
                    using (var saveImageStream = System.IO.File.Open(filename, FileMode.Create))
                    {
                        await client.DownloadFileAsync(file.FilePath, saveImageStream);
                    }

                    await client.SendTextMessageAsync(message.Chat.Id, "Thx for the Pics");
                    break;
            }


            //foreach (var command in commands)
            //{
            //    if (command.Contains(message.Text))
            //    {
            //        command.Execute(message, client);
            //        break;
            //    }
            //}

            return Ok();
        }
    }
}
