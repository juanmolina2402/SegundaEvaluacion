using SegundaEvaluacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.DAL
{
    public class CustomerDAL
    {
        public static List<Customer> lstCustomer = new List<Customer>();

        public CustomerDAL() { }

        public int insertarCustomer(Customer customer)
        {
            try
            {
                //Si el listado tiene elementos, entonces se genera el ID
                if (lstCustomer.Count > 0)
                {
                    customer.idCustomer = lstCustomer.Last().idCustomer + 1;
                }
                else
                {
                    //Si el listado esta vacio entonces el id será por default 1
                    customer.idCustomer = 1;
                }
                lstCustomer.Add(customer);
                return customer.idCustomer;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarCustomer(int id, Customer customer)
        {
            try
            {
                //Buscando el indice en la ista
                lstCustomer[lstCustomer.FindIndex(temp => temp.idCustomer == id)] = customer;
                return customer.idCustomer;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminarCustomer(int id)
        {
            try
            {
                //Buscando el indice en la ista
                lstCustomer.RemoveAt(lstCustomer.FindIndex(aux => aux.idCustomer == id));
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Para listar todos las carreras
        public List<Customer> obtenerTodos()
        {
            return lstCustomer;
        }

        //Para encontrar una carrera por ID
        public Customer obtenerPorID(int id)
        {
            try
            {
                var elementos = lstCustomer.Find(temp => temp.idCustomer == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}