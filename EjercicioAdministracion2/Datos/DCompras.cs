﻿using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Datos
{
    public class DCompras
    {
        public static void Create(Compras c)
        {

            string sql = @"
                    INSERT INTO Compras (fecha,proveedor,tipoComprobante,puntoVenta,numero,netoTotal,ivaTotal,noGravado,otrosTributos,usuario) 
                    VALUES (@fecha,@proveedor,@tipoComprobante,@puntoVenta,@numero,@netoTotal,@ivaTotal,@noGravado,@otrosTributos,@usuario)
                ";

            using (SqlConnection cn = Db.GetConnection())
            {

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {

                    cmd.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime).Value = c.fecha;
                    cmd.Parameters.Add("@proveedor", System.Data.SqlDbType.Int).Value = c.proveedor.id;
                    cmd.Parameters.Add("@tipoComprobante", System.Data.SqlDbType.Int).Value = c.tipoComprobante.id;
                    cmd.Parameters.Add("@puntoVenta", System.Data.SqlDbType.VarChar).Value = c.puntoVenta;
                    cmd.Parameters.Add("@numero", System.Data.SqlDbType.VarChar).Value = c.numero;
                    cmd.Parameters.Add("@netoTotal", System.Data.SqlDbType.Decimal).Value = c.netoTotal;
                    cmd.Parameters.Add("@ivaTotal", System.Data.SqlDbType.Decimal).Value = c.ivaTotal;
                    cmd.Parameters.Add("@noGravado", System.Data.SqlDbType.Decimal).Value = c.noGravado;
                    cmd.Parameters.Add("@otrosTributos", System.Data.SqlDbType.Decimal).Value = c.otrosTributos;
                    cmd.Parameters.Add("@usuario", System.Data.SqlDbType.Int).Value = c.usuario.id;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<Compras> getAll()
        {
            List<Compras> lista = new List<Compras>();

            string sql = @"Select * from Compras";

            using (SqlConnection cn = Db.GetConnection())
            {

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Compras c = new Compras();
                            {
                                c.id = reader.GetInt32(0);
                                c.fecha = reader.GetDateTime(1);
                                c.proveedor = new Proveedores { id = reader.GetInt16(2) };
                                c.tipoComprobante = new TipoComprobante { id = reader.GetInt16(3) };
                                c.puntoVenta = reader.GetString(4);
                                c.numero = reader.GetString(5);
                                c.netoTotal = reader.GetDecimal(6);
                                c.ivaTotal = reader.GetDecimal(7);
                                c.noGravado = reader.GetDecimal(8);
                                c.otrosTributos = reader.GetDecimal(9);
                                c.usuario = new Usuarios { id = reader.GetInt16(10) };

                            }
                            ;

                            lista.Add(c);

                        }
                    }
                }
            }

            return lista;
        }
        public static void Delete(int id)
        {
            string sql = @"Delete from Compras where id = @id";
            using (SqlConnection cn = Db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.UniqueIdentifier).Value = id;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Update(Compras c)
        {
            
            string sql = @"
                    UPDATE Compras SET 
                    fecha = @fecha,
                    proveedor = @proveedor,
                    tipoComprobante = @tipoComprobante,
                    puntoVenta = @puntoVenta,
                    numero = @numero,
                    netoTotal = @netoTotal,
                    ivaTotal = @ivaTotal,
                    noGravado = @noGravado,
                    otrosTributos = @otrosTributos,
                    usuario = @usuario
                    WHERE id = @id
                ";
            
            using (SqlConnection cn = Db.GetConnection())
            {
                
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value = c.id;
                    cmd.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime).Value = c.fecha;
                    cmd.Parameters.Add("@proveedor", System.Data.SqlDbType.Int).Value = c.proveedor.id;
                    cmd.Parameters.Add("@tipoComprobante", System.Data.SqlDbType.Int).Value = c.tipoComprobante.id;
                    cmd.Parameters.Add("@puntoVenta", System.Data.SqlDbType.VarChar).Value = c.puntoVenta;
                    cmd.Parameters.Add("@numero", System.Data.SqlDbType.VarChar).Value = c.numero;
                    cmd.Parameters.Add("@netoTotal", System.Data.SqlDbType.Decimal).Value = c.netoTotal;
                    cmd.Parameters.Add("@ivaTotal", System.Data.SqlDbType.Decimal).Value = c.ivaTotal;
                    cmd.Parameters.Add("@noGravado", System.Data.SqlDbType.Decimal).Value = c.noGravado;
                    cmd.Parameters.Add("@otrosTributos", System.Data.SqlDbType.Decimal).Value = c.otrosTributos;
                    cmd.Parameters.Add("@usuario", System.Data.SqlDbType.Int).Value = c.usuario.id;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
