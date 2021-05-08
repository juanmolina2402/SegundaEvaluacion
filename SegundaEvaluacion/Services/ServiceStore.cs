using SegundaEvaluacion.DAL;
using SegundaEvaluacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.Services
{
    public class ServiceStore
    {
        public StoreDAL storeDal = new StoreDAL();

        public int insertar(Store store)
        {
            try
            {
                return storeDal.insertarStore(store);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Store store)
        {
            try
            {
                return storeDal.modificarStore(id, store);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminar(int id)
        {
            try
            {
                return storeDal.eliminarStore(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Store> obtenerTodos()
        {
            return storeDal.obtenerTodos();
        }

        public Store obtenerPorId(int id)
        {
            try
            {
                return storeDal.obtenerPorID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}