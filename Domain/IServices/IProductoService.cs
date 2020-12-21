﻿using ProyectoTituloBackend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTituloBackend.Domain.IServices
{
  public  interface IProductoService
    {

        Task CreateProducto(Producto producto);


        Task<Producto> GetProducto(int idProducto);

        Task EliminarProducto(Producto producto);

        Task<List<Producto>> GetListProducto();

        Task ActualizarProducto(int id, Producto producto);

        Task<Producto> BuscarProducto(int idProducto);
    }
}
