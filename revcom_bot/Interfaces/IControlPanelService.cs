using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMKTelegramBot.DTO;

namespace TerminalMKTelegramBot.Interfaces
{
    public interface IControlPanelService
    {
        IEnumerable<ProductionDTO> GetProduction();

        IEnumerable<MessagesDTO> GetMessages();

        bool CheckMessages();

        int ProductionCreate(ProductionDTO productionDTO);
        void ProductionUpdate(ProductionDTO productionDTO);
        bool ProductionDelete(int id);

        int MessagesCreate(MessagesDTO messagesDTO);
        void MessagesUpdate(MessagesDTO messagesDTO);
        bool MessagesDelete(int id);

    }
}
