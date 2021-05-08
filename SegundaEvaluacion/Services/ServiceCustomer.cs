using SegundaEvaluacion.DAL;
using SegundaEvaluacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.Services
{
    public class ServiceCustomer
    {
        public CustomerDAL customerDal = new CustomerDAL();

        public int insertar(Customer customer)
        {
            try
            {
                return customerDal.insertarCustomer(customer);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Customer customer)
        {
            try
            {
                return customerDal.modificarCustomer(id, customer);
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
                return customerDal.eliminarCustomer(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Customer> obtenerTodos()
        {
            return customerDal.obtenerTodos();
        }

        public Customer obtenerPorId(int id)
        {
            try
            {
                return customerDal.obtenerPorID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}