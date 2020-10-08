using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dispensadora
    {
        public List<Producto> productos { get; set; }
        public string Pago { get; set; }
        public object Codigo { get; }

        public Dispensadora()
        {
            Producto cocacola = new Producto();
            cocacola.Codigo = "01";
            cocacola.Nombre = "Coca Cola";
            cocacola.Categoria = "B";
            cocacola.Cantidad = 6;
            cocacola.Valor = 10;

            Producto papas = new Producto();
            papas.Codigo = "02";
            papas.Nombre = "Papitas";
            papas.Categoria = "M";
            papas.Cantidad = 15;
            papas.Valor = 5;

            Producto tortrix = new Producto();
            tortrix.Codigo = "03";
            tortrix.Nombre = "Tortrix";
            tortrix.Categoria = "M";
            tortrix.Cantidad = 10;
            tortrix.Valor = 8;

            this.productos.Add(cocacola);
            this.productos.Add(papas);
            this.productos.Add(tortrix);

            public bool validar(string codigo);

            {
                int encontro = -1;
                for (int i = 0; i < this.productos.Count; i++)
                {
                    if (this.productos[i] == Codigo)
                    {
                        encontro = i;
                    }

                }

                return encontro;



            }


            public bool agregar(Producto producto)
            {
                int enc = this.validar(Codigo);
                if (enc >= 0)
                {
                    this.productos[enc].sumar(producto.Cantidad);

                }
                else
                {

                    this.productos.Add(producto);
                }
                return true;

                public bool eliminar(string codigo)
                {
                    int enc = this.validar(Codigo);
                    if (enc >= 0)
                    {
                        this.productos.RemoveAll(enc);
                    }


                    return true;

                }
                public Producto validarMonedas(string[] monedas)
                {
                    float total = 0;
                    foreach (string item in monedas)
                    {
                        try
                        {
                            total += float.Parse(item);

                        }
                        catch (Exception e) { }
                    }



                }
            }
            return null;

            public Producto vender(string Codigo)
            {
                int enc = this.validar(Codigo);
                if (enc >= 0)
                {
                    if (this.productos[enc].valida())
                    {
                        string[] monedas = this.Pago.Split('-');
                        double total = this.validarMonedas()
                            if (this.productos[enc].validarValor(total))
                        {
                            this.productos[enc].restar();
                            return this.productos[enc];
                        }



                    }
                }
                return null;
            }
            public bool validarvalor(double valor)
            {
                if (this.valor <= valor)
                {
                    this.cambio = valor - this.valor;
                    return true;
                }
                return false;
            }
            public void restar()
            {
                this.cantidad--;
            }


            public string enlistarproductos()
            {
                string lista = "";
                foreach (Producto item in this.productos)
                {
                    lista += item.Codigo + "" + item.Nombre + "" + item.Cantidad + "" + item.Valor;

                }
                return lista;
            }













        }
    }

        private int validar(object codigo)
        {
            throw new NotImplementedException();
        }
    



