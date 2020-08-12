using System.Collections.Generic;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.BLL.Interfaces
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
