using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMK.BLL.Interfaces;
using TerminalMK.BLL.ModelsDTO;
using TerminalMK.DAL.Interfaces;
using TerminalMK.DAL.Models;

namespace TerminalMK.BLL.Services
{
    public class MySqlService : IMySqlService
    {

        private IUnitOfWorkMysql Database { get; set; }
        private IRepository<City> city;


        private IMapper mapper;

        public MySqlService(IUnitOfWorkMysql uowsql)
        {
            Database = uowsql;

            city = Database.GetRepository<City>();


            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<City, CityDTO>();
                cfg.CreateMap<CityDTO, City>();
                
            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<CityDTO> GetCity()
        {
            return mapper.Map<IEnumerable<City>, List<CityDTO>>(city.GetAll());
        }
    }
}
