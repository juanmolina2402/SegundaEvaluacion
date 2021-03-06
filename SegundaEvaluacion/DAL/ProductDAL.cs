using SegundaEvaluacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.DAL
{
    public class ProductDAL
    {
        public static List<Product> lstProduct = new List<Product>();

        public ProductDAL() { }

        public int insertarProduct(Product product)
        {
            try
            {
                //Si el listado tiene elementos, entonces se genera el ID
                if (lstProduct.Count > 0)
                {
                    product.id = lstProduct.Last().id + 1;
                }
                else
                {
                    //Si el listado esta vacio entonces el id será por default 1
                    product.id = 1;
                }
                lstProduct.Add(product);
                return product.id;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarProduct(int id, Product product)
        {
            try
            {
                //Buscando el indice en la ista
                lstProduct[lstProduct.FindIndex(temp => temp.id == id)] = product;
                return product.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Para eliminar una carrera del listado
        public bool eliminarProduct(int id)
        {
            try
            {
                //Buscando el indice en la ista
                lstProduct.RemoveAt(lstProduct.FindIndex(aux => aux.id == id));
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Para listar todos las carreras
        public List<Product> obtenerTodos()
        {
            return lstProduct;
        }

        //Para encontrar una carrera por ID
        public Product obtenerPorID(int id)
        {
            try
            {
                var elementos = lstProduct.Find(temp => temp.id == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}