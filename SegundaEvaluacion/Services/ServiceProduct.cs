using SegundaEvaluacion.DAL;
using SegundaEvaluacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.Services
{
    public class ServiceProduct
    {
        public ProductDAL productDal = new ProductDAL();

        public int insertar(Product product)
        {
            try
            {
                return productDal.insertarProduct(product);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Product product)
        {
            try
            {
                return productDal.modificarProduct(id, product);
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
                return productDal.eliminarProduct(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Para obtener todos los estudiantes
        public List<Product> obtenerTodos()
        {
            return productDal.obtenerTodos();
        }

        //Para obtener por ID

        public Product obtenerPorId(int id)
        {
            try
            {
                return productDal.obtenerPorID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}