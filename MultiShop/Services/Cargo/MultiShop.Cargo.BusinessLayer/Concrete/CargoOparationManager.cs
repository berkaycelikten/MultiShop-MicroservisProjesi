using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoOparationManager : ICargoOperationService
    {
        private readonly ICargoOperationDal _cargoOperationDal;

        public CargoOparationManager(ICargoOperationDal cargoOperationDal)
        {
            _cargoOperationDal = cargoOperationDal;
        }

        public void TDelete(int id)
        {
            _cargoOperationDal.Delete(id);
        }

        public CargoOperation TGetById(int id)
        {
           return _cargoOperationDal.GetById(id);
        }

        public List<CargoOperation> TGetAll()
        {
            return _cargoOperationDal.GetAll();
        }

        public void TInsert(CargoOperation entity)
        {
           _cargoOperationDal.Insert(entity);
        }

        public void TUpdate(CargoOperation entity)
        {
            _cargoOperationDal.Update(entity);
        }
    }
}
