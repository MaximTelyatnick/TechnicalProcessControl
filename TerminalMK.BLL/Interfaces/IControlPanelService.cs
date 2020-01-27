using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMK.BLL.ModelsDTO;

namespace TerminalMK.BLL.Interfaces
{
    public interface IControlPanelService
    {
        IEnumerable<ProductionDTO> GetProduction();

        IEnumerable<MessagesDTO> GetMessages();

        bool CheckMessages();
        bool ContainMessages(long telegramId);

        int ProductionCreate(ProductionDTO productionDTO);
        bool ProductionUpdate(ProductionDTO productionDTO);
        bool ProductionDelete(int id);

        int MessagesCreate(MessagesDTO messagesDTO);
        void MessagesUpdate(MessagesDTO messagesDTO);

        bool MessagesUpdateRange(List<MessagesDTO> source);
        bool MessagesDelete(int id);

    }
}
