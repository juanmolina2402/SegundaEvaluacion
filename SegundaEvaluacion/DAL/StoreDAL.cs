using SegundaEvaluacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.DAL
{
    public class StoreDAL
    {
        public static List<Store> lstStore = new List<Store>();

        public StoreDAL() { }

        public int insertarStore(Store store)
        {
            try
            {
                //Si el listado tiene elementos, entonces se genera el ID
                if (lstStore.Count > 0)
                {
                    store.id = lstStore.Last().id + 1;
                }
                else
                {
                    //Si el listado esta vacio entonces el id será por default 1
                    store.id = 1;
                }
                lstStore.Add(store);
                return store.id;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarStore(int id, Store store)
        {
            try
            {
                //Buscando el indice en la ista
                lstStore[lstStore.FindIndex(temp => temp.id == id)] = store;
                return store.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminarStore(int id)
        {
            try
            {
                //Buscando el indice en la ista
                lstStore.RemoveAt(lstStore.FindIndex(aux => aux.id == id));
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Para listar todos las carreras
        public List<Store> obtenerTodos()
        {
            return lstStore;
        }

        //Para encontrar una carrera por ID
        public Store obtenerPorID(int id)
        {
            try
            {
                var elementos = lstStore.Find(temp => temp.id == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}