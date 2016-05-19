using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_MariaEduarte
{
    class Program
    {
        static void Main(string[] args)
        
{
                Console.WriteLine("Libreria El Buen Lector");
                Console.WriteLine("Ingresar su nombre");
                string nombre;
                nombre = Console.ReadLine();
                Console.WriteLine("Ingredar su número de teléfono ");
                int telefono;
                telefono = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿Qué libro desea comprar ?");
                Console.WriteLine("1) El Señor de los Anillos (Fantasía)");
            Console.WriteLine("2) Alicia en el país de las Maravillas (Infantil)");
            Console.WriteLine("3) Cementerio de Mascotas (Misterio)");
            Console.WriteLine("4) Quiero aprender (Educativo)");
            Console.WriteLine("5) El poder del pensamiento Positivo (Superación)");
            Console.WriteLine("6) Mi primer libro de matemáticas (Educativo) ");
            Console.WriteLine("7) Las aventuras de Tom Sawyer (Infantil)");
            Console.WriteLine("8) El mago de OZ (Fantasía)");
            Console.WriteLine("9) La zona muerta(Misterio)");
            Console.WriteLine("10) Viaje al centro de la tierra (Ciencia Ficción)");
            Console.Write("Seleccione una opción: ");
            
            
        
       
            
                switch (Console.ReadLine())

                {

                    case "1":
           
                        int L1 = 5700;
                        double cantidad, suma, descuento, total, recibo, cambio;
                        Console.WriteLine("El Costo del Libro es " + L1 + " colones");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        descuento = (cantidad * L1) * 0.15;
                        suma = (cantidad * L1) - descuento;
                        total = (suma * 0.13) + suma;
                        Console.WriteLine("El Costo total de la compra es " + total + " colones");
                        Console.WriteLine("Ingrese el monto a cancelar");
                        recibo = Convert.ToInt32(Console.ReadLine());
                        if (recibo == total || recibo > total)
                        {
                            cambio = recibo - total;
                        }
                        else
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total");
                            recibo = Convert.ToInt32(Console.ReadLine());
                            cambio = total;
                        

                    }
                        Console.Clear();
                        Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente  " + nombre);
                        Console.WriteLine("Teléfono  " + telefono);
                        Console.WriteLine("Película El Señor de los Anillos ");
                        Console.WriteLine("Precio  " + L1 + "Colones/ Cantidad   " + cantidad);
                        Console.WriteLine("Total Orden" + suma + "Descuento  " + descuento);
                        Console.WriteLine("Impuesto: 13% / Precio Neto:    " + total);
                        Console.WriteLine("Monto Recibido  " + recibo);
                        Console.WriteLine("Monto Cambio  " + cambio);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case "2":
                        int L2 = 6300;
                        double cantidad1, suma1, descuento1, total1, recibo1, cambio1;
                        Console.WriteLine("El Costo del Libro es " + L2 + " colones  ");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad1 = Convert.ToInt32(Console.ReadLine());
                        descuento1 = (cantidad1 * L2) * 0.05;
                        suma1 = (cantidad1 * L2) - descuento1;
                        total1 = (suma1 * 0.13) + suma1;
                        Console.WriteLine("El Costo total de la compra es " + total1 + " colones  ");
                        Console.WriteLine("Ingrese el monto a cancelar  ");
                        recibo1 = Convert.ToInt32(Console.ReadLine());
                        if (recibo1 == total1 || recibo1 > total1)
                        {
                            cambio1 = recibo1 - total1;
                        }
                        else
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total  ");
                            recibo1 = Convert.ToInt32(Console.ReadLine());
                        cambio1 = total1;
                    }
                         Console.Clear();
                         Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente" + nombre);
                        Console.WriteLine("Teléfono" + telefono);
                        Console.WriteLine("Película Alicia en el país de las Maravillas ");
                        Console.WriteLine("Precio" + L2 + "Colones/ Cantidad" + cantidad1);
                        Console.WriteLine("Total Orden" + suma1 + "Descuento" + descuento1);
                        Console.WriteLine("Impuesto: 13% / Precio Neto: " + total1);
                        Console.WriteLine("Monto Recibido" + recibo1);
                        Console.WriteLine("Monto Cambio" + cambio1);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":

                        int L3 = 8200;
                        double cantidad2, suma2, descuento2, total2, recibo2, cambio2;
                        Console.WriteLine("El Costo del Libro es " + L3 + " colones");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad2 = Convert.ToInt32(Console.ReadLine());
                        descuento2 = (cantidad2 * L3) * 0.10;
                        suma2 = (cantidad2 * L3) - descuento2;
                        total2 = (suma2 * 0.13) + suma2;
                        Console.WriteLine("El Costo total de la compra es " + total2 + " colones");
                        Console.WriteLine("Ingrese el monto a cancelar");
                        recibo2 = Convert.ToInt32(Console.ReadLine());
                        if (recibo2 == total2 || recibo2 > total2)
                        {
                        cambio2 = recibo2 - total2;
                        }
                        else
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total");
                            recibo2 = Convert.ToInt32(Console.ReadLine());
                        cambio2 = total2;

                    }
                        Console.Clear();
                       Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente" + nombre);
                        Console.WriteLine("Teléfono" + telefono);
                        Console.WriteLine("Película Cementerio de Mascotas ");
                        Console.WriteLine("Precio" + L3 + "Colones/ Cantidad" + cantidad2);
                        Console.WriteLine("Total Orden" + suma2 + "Descuento" + descuento2);
                        Console.WriteLine("Impuesto: 13% / Precio Neto: " + total2);
                        Console.WriteLine("Monto Recibido" + recibo2);
                        Console.WriteLine("Monto Cambio" + cambio2);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":

                        int L4 = 5800;
                        double cantidad3, suma3, descuento3, total3, recibo3, cambio3;
                        Console.WriteLine("El Costo del Libro es " + L4 + " colones");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad3 = Convert.ToInt32(Console.ReadLine());
                        descuento3 = (cantidad3 * L4) * 0.20;
                        suma3 = (cantidad3 * L4) - descuento3;
                        total3 = (suma3 * 0.13) + suma3;
                        Console.WriteLine("El Costo total de la compra es " + total3 + " colones");
                        Console.WriteLine("Ingrese el monto a cancelar");
                        recibo3 = Convert.ToInt32(Console.ReadLine());
                        if (recibo3 == total3 || recibo3 > total3)
                        {
                            cambio3 = recibo3 - total3;
                        }
                        else
                        cambio3 = total3;
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total");
                            recibo3 = Convert.ToInt32(Console.ReadLine());
                        }
                    Console.Clear();
                    Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente" + nombre);
                        Console.WriteLine("Teléfono" + telefono);
                        Console.WriteLine("Película Quiero aprender");
                        Console.WriteLine("Precio" + L4 + "Colones/ Cantidad" + cantidad3);
                        Console.WriteLine("Total Orden" + suma3 + "Descuento" + descuento3);
                        Console.WriteLine("Impuesto: 13% / Precio Neto: " + total3);
                        Console.WriteLine("Monto Recibido" + recibo3);
                        Console.WriteLine("Monto Cambio" + cambio3);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":

                        int L5 = 9300;
                        double cantidad4, suma4, descuento4, total4, recibo4, cambio4;
                        Console.WriteLine("El Costo del Libro es " + L5 + " colones");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad4 = Convert.ToInt32(Console.ReadLine());
                        descuento4 = (cantidad4 * L5) * 0.25;
                        suma4 = (cantidad4 * L5) - descuento4;
                        total4 = (suma4 * 0.13) + suma4;
                        Console.WriteLine("El Costo total de la compra es " + total4 + " colones");
                        Console.WriteLine("Ingrese el monto a cancelar");
                        recibo4 = Convert.ToInt32(Console.ReadLine());
                        if (recibo4 == total4 || recibo4 > total4)
                        {
                            cambio4 = recibo4 - total4;
                        }
                        else
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total");
                            recibo4 = Convert.ToInt32(Console.ReadLine());
                            cambio4 = total4;
                    }
                    Console.Clear();
                    Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente" + nombre);
                        Console.WriteLine("Teléfono" + telefono);
                        Console.WriteLine("Película El poder del pensamiento Positivo ");
                        Console.WriteLine("Precio" + L5 + "Colones/ Cantidad" + cantidad4);
                        Console.WriteLine("Total Orden" + suma4 + "Descuento" + descuento4);
                        Console.WriteLine("Impuesto: 13% / Precio Neto: " + total4);
                        Console.WriteLine("Monto Recibido" + recibo4);
                        Console.WriteLine("Monto Cambio" + cambio4);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "6":

                        int L6 = 6950;
                        double cantidad5, suma5, descuento5, total5, recibo5, cambio5;
                        Console.WriteLine("El Costo del Libro es " + L6 + " colones");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad5 = Convert.ToInt32(Console.ReadLine());
                        descuento5 = (cantidad5 * L6) * 0.20;
                        suma5 = (cantidad5 * L6) - descuento5;
                        total5 = (suma5 * 0.13) + suma5;
                        Console.WriteLine("El Costo total de la compra es " + total5 + " colones");
                        Console.WriteLine("Ingrese el monto a cancelar");
                        recibo5 = Convert.ToInt32(Console.ReadLine());
                        if (recibo5 == total5 || recibo5 > total5)
                        {
                         cambio5 = recibo5 - total5;
                        }
                        else
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total");
                        recibo5 = Convert.ToInt32(Console.ReadLine());
                            cambio5 = total5;
                    }
                    Console.Clear();
                    Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente" + nombre);
                        Console.WriteLine("Teléfono" + telefono);
                        Console.WriteLine("Película  Mi primer libro de matemáticas ");
                        Console.WriteLine("Precio" + L6 + "Colones/ Cantidad" + cantidad5);
                        Console.WriteLine("Total Orden" + suma5 + "Descuento" + descuento5);
                        Console.WriteLine("Impuesto: 13% / Precio Neto: " + total5);
                        Console.WriteLine("Monto Recibido" + recibo5);
                        Console.WriteLine("Monto Cambio" + cambio5);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "7":

                        int L7 = 4100;
                        double cantidad6, suma6, descuento6, total6, recibo6, cambio6;
                        Console.WriteLine("El Costo del Libro es " + L7 + " colones");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad6 = Convert.ToInt32(Console.ReadLine());
                        descuento6 = (cantidad6 * L7) * 0.05;
                        suma6 = (cantidad6 * L7) - descuento6;
                        total6 = (suma6 * 0.13) + suma6;
                        Console.WriteLine("El Costo total de la compra es " + total6 + " colones");
                        Console.WriteLine("Ingrese el monto a cancelar");
                        recibo6 = Convert.ToInt32(Console.ReadLine());
                        if (recibo6 == total6 || recibo6 > total6)
                        {
                            cambio6 = recibo6 - total6;
                        }
                        else
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total");
                            recibo6 = Convert.ToInt32(Console.ReadLine());
                            cambio6 = total6;
                    }
                    Console.Clear();
                    Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente" + nombre);
                        Console.WriteLine("Teléfono" + telefono);
                        Console.WriteLine("Película Las aventuras de Tom Sawyer ");
                        Console.WriteLine("Precio" + L7 + "Colones/ Cantidad" + cantidad6);
                        Console.WriteLine("Total Orden" + suma6 + "Descuento" + descuento6);
                        Console.WriteLine("Impuesto: 13% / Precio Neto: " + total6);
                        Console.WriteLine("Monto Recibido" + recibo6);
                        Console.WriteLine("Monto Cambio" + cambio6);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case "8":

                        int L8 = 3500;
                        double cantidad7, suma7, descuento7, total7, recibo7, cambio7;
                        Console.WriteLine("El Costo del Libro es " + L8 + " colones");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad7 = Convert.ToInt32(Console.ReadLine());
                        descuento7 = (cantidad7 * L8) * 0.15;
                        suma7 = (cantidad7 * L8) - descuento7;
                        total7 = (suma7 * 0.13) + suma7;
                        Console.WriteLine("El Costo total de la compra es " + total7 + " colones");
                        Console.WriteLine("Ingrese el monto a cancelar");
                        recibo7 = Convert.ToInt32(Console.ReadLine());
                        if (recibo7 == total7 || recibo7 > total7)
                        {
                            cambio7 = recibo7 - total7;
                        }
                        else
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total");
                            recibo7 = Convert.ToInt32(Console.ReadLine());
                            cambio7 = total7;
                    }
                    Console.Clear();
                    Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente" + nombre);
                        Console.WriteLine("Teléfono" + telefono);
                        Console.WriteLine("Película El mago de OZ ");
                        Console.WriteLine("Precio" + L8 + "Colones/ Cantidad" + cantidad7);
                        Console.WriteLine("Total Orden" + suma7 + "Descuento" + descuento7);
                        Console.WriteLine("Impuesto: 13% / Precio Neto: " + total7);
                        Console.WriteLine("Monto Recibido" + recibo7);
                        Console.WriteLine("Monto Cambio" + cambio7);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();

                        Console.Clear();
                        break;


                    case "9":

                        int L9 = 8700;
                        double cantidad8, suma8, descuento8, total8, recibo8, cambio8;
                        Console.WriteLine("El Costo del Libro es " + L9 + " colones");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad8 = Convert.ToInt32(Console.ReadLine());
                        descuento8 = (cantidad8 * L9) * 0.10;
                        suma8 = (cantidad8 * L9) - descuento8;
                        total8 = (suma8 * 0.13) + suma8;
                        Console.WriteLine("El Costo total de la compra es " + total8 + " colones");
                        Console.WriteLine("Ingrese el monto a cancelar");
                        recibo8 = Convert.ToInt32(Console.ReadLine());
                        if (recibo8 == total8 || recibo8 > total8)
                        {
                            cambio8 = recibo8 - total8;
                        }
                        else
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total");
                            recibo8 = Convert.ToInt32(Console.ReadLine());
                            cambio8 = total8;
                    }
                    Console.Clear();
                    Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente" + nombre);
                        Console.WriteLine("Teléfono" + telefono);
                        Console.WriteLine("Película La zona muerta ");
                        Console.WriteLine("Precio" + L9 + "Colones/ Cantidad" + cantidad8);
                        Console.WriteLine("Total Orden" + suma8 + "Descuento" + descuento8);
                        Console.WriteLine("Impuesto: 13% / Precio Neto: " + total8);
                        Console.WriteLine("Monto Recibido" + recibo8);
                        Console.WriteLine("Monto Cambio" + cambio8);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "10":

                        int L10 = 7500;
                        double cantidad9, suma9, descuento9, recibo9, total9, cambio9;
                        Console.WriteLine("El Costo del Libro es " + L10 + " colones");
                        Console.WriteLine("¿Cuántos libros desea comprar?");
                        cantidad9 = Convert.ToInt32(Console.ReadLine());
                        descuento9 = ((cantidad9 * L10) * 0.25);
                        suma9 = (cantidad9 * L10) - descuento9;
                        total9 = (suma9 * 0.13) + suma9;
                        Console.WriteLine("El Costo total de la compra es " + total9 + " colones");
                        Console.WriteLine("Ingrese el monto a cancelar");
                        recibo9 = Convert.ToInt32(Console.ReadLine());
                        if (recibo9 == total9 || recibo9 > total9)
                        {
                            cambio9 = recibo9 - total9;
                        }
                        else
                    {
                            Console.WriteLine("Ingrese el monto un monto mayor al total");
                            recibo9 = Convert.ToInt32(Console.ReadLine());
                            cambio9 = total9;
                    }
                    Console.Clear();
                    Console.WriteLine("Librería El Buen Lector");
                        Console.WriteLine("Factura Proforma");
                        Console.WriteLine("Cliente" + nombre);
                        Console.WriteLine("Teléfono" + telefono);
                        Console.WriteLine("Película Viaje al centro de la tierra");
                        Console.WriteLine("Precio" + L10 + "Colones/ Cantidad" + cantidad9);
                        Console.WriteLine("Total Orden" + suma9 + "Descuento" + descuento9);
                        Console.WriteLine("Impuesto: 13% / Precio Neto: " + total9);
                        Console.WriteLine("Monto Recibido" + recibo9);
                        Console.WriteLine("Monto Cambio" + cambio9);
                        Console.WriteLine("Gracias por su compra…");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    default:
                        Console.Write("Escribe un número que  está en el menú");
                        break;

                }
            }

        }
    }

