﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.DAL.Interfaces;
using TechnicalProcessControl.DAL.Models;

namespace TerminalMKTelegramBot.Services
{
    public class ControlPanelService: IControlPanelService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Production> production;
        private IRepository<Messages> messages;

        private IMapper mapper;

        public ControlPanelService(IUnitOfWork uow)
        {
            Database = uow;

            production = Database.GetRepository<Production>();
            messages = Database.GetRepository<Messages>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Production, ProductionDTO>();
                cfg.CreateMap<ProductionDTO, Production>();
                cfg.CreateMap<Messages, MessagesDTO>();
                cfg.CreateMap<MessagesDTO, Messages>();
            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<ProductionDTO> GetProduction()
        {
            return mapper.Map<IEnumerable<Production>, List<ProductionDTO>>(production.GetAll());
        }

        public IEnumerable<MessagesDTO> GetMessages()
        {
            return mapper.Map<IEnumerable<Messages>, List<MessagesDTO>>(messages.GetAll());
        }

        

        public bool CheckMessages()
        {
            bool? checkMessage =  mapper.Map<IEnumerable<Messages>, List<MessagesDTO>>(messages.GetAll()).Any(bdsm => bdsm.Read == false);

            bool newBool = checkMessage.HasValue ? checkMessage.Value : true;

            return newBool;
        }

        public bool ContainMessages(long telegramId)
        {
            bool? checkMessage = mapper.Map<IEnumerable<Messages>, List<MessagesDTO>>(messages.GetAll()).Any(bdsm => bdsm.UserTelegramId == telegramId);

            bool newBool = checkMessage.HasValue ? checkMessage.Value : false;

            return newBool;
        }


        #region Production's CRUD method's

        public int ProductionCreate(ProductionDTO productionDTO)
        {
            var createProductiont = production.Create(mapper.Map<Production>(productionDTO));
            return (int)createProductiont.Id;
        }

        public bool ProductionUpdate(ProductionDTO productionDTO)
        {
            var updateProduction = production.GetAll().SingleOrDefault(c => c.Id == productionDTO.Id);
            if (updateProduction != null)
            {
                production.Update((mapper.Map<ProductionDTO, Production>(productionDTO, updateProduction)));
                return true;
            }
            else
                return false;
        }

        public bool ProductionDelete(int id)
        {
            try
            {
                production.Delete(production.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Messages CRUD method's

        public int MessagesCreate(MessagesDTO messagesDTO)
        {
            var createMessages = messages.Create(mapper.Map<Messages>(messagesDTO));
            return (int)createMessages.Id;
        }

        public void MessagesUpdate(MessagesDTO messagesDTO)
        {
            var updateMessages = messages.GetAll().SingleOrDefault(c => c.Id == messagesDTO.Id);
            messages.Update((mapper.Map<MessagesDTO, Messages>(messagesDTO, updateMessages)));
        }

        public bool MessagesDelete(int id)
        {
            try
            {
                messages.Delete(messages.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool MessagesUpdateRange(List<MessagesDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var updateMessages = messages.GetAll().SingleOrDefault(c => c.Id == item.Id);
                    messages.Update((mapper.Map<MessagesDTO, Messages>(item, updateMessages)));
                }


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

    }
}
