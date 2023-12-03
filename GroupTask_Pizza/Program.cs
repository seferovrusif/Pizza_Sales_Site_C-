﻿using GroupTask_Pizza.Models;
using GroupTask_Pizza.Utilies.Services;
using GroupTask_Pizza.Utilies.Validation;
using System.Runtime.ConstrainedExecution;

namespace GroupTask_Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database.Products.Add(new Product("Italiano Pizza", 15, 5));
            Database.Products.Add(new Product("Mixed Pizza", 20, 5));
            Database.Products.Add(new Product("Mexican Pizza", 30, 5));
            Database.Products.Add(new Product("Head Papa John's Pizza", 25, 5));
            Database.Products.Add(new Product("Vegetarian Pizza", 15, 5));

            User user1 = new User("admin@gmail.com", "1234Abc", "admin", "admin"); user1.role = Role.Admin;
            Database.Users.Add(user1);



            Role rol = Role.Default;
            bool iscontinue = true;
            while (iscontinue)
            {
                try
                {
                point1:
                    Console.WriteLine("1. Girish edin\n2. Qeydiyatdan kechin\n3. Proqrami dayandirin");
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "1":
                            Console.WriteLine("Mail-i daxil edin:"); string mail = Console.ReadLine();
                            if (UserValidation.MailValidation(mail))
                            {
                                Console.WriteLine("Shifreni daxil edin:"); string password = Console.ReadLine();
                                if (UserValidation.PasswordValidation(password))
                                {
                                    rol = UsersService.GetUserById(SignInSignUpService.SignIn(mail, password)).role;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong Input!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input!");
                            }
                            break;
                        case "2":
                            var aa = UserValidation.SignUpValidation();
                            SignInSignUpService.SignUp(aa.Item1, aa.Item2, aa.Item3, aa.Item4);
                            goto point1;
                        case "3":
                            iscontinue = false;
                            break;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                while (rol == Role.Admin)
                {
                    try
                    {
                        Console.WriteLine($"1. Pizzalar(Admin)\n2. Userler(Adim)\n3. Mehsullara bax\n4. Sebete elave et\n5. Sebete bax\n6. Sifarisi tamamla\n7. Sifarishlere bax\n8. Hesabdan Cix ");
                        string b = Console.ReadLine();
                        switch (b)

                        {

                            case "1":
                            case "2":
                                Console.WriteLine($"1. Hamsina bax\n2. Elave et\n3. Duzelis et (ID ile)\n4. Sil (ID ile)");
                                b = b + Console.ReadLine();
                                switch (b)
                                {
                                    case "11":
                                        ProductService.GetAllProducts();
                                        break;
                                    case "21":
                                        UsersService.GetAllUsers();
                                        break;
                                    case "12":
                                        Console.WriteLine("NAme-Price-count");
                                        ProductService.AddProduct(Console.ReadLine(), Convert.ToDecimal(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                                        break;
                                    case "22":
                                        var aa = UserValidation.SignUpValidation();
                                        SignInSignUpService.SignUp(aa.Item1, aa.Item2, aa.Item3, aa.Item4); break;
                                    case "13":
                                        Console.WriteLine("enter id");
                                        ProductService.UpdateProduct(Convert.ToInt32(Console.ReadLine()));
                                        break;
                                    case "23":
                                        Console.WriteLine("enter id");
                                        UsersService.UpdateUser(Convert.ToInt32(Console.ReadLine()));
                                        break;
                                    case "14":
                                        Console.WriteLine("enter id");
                                        ProductService.RemoveProduct(Convert.ToInt32(Console.ReadLine()));
                                        break;
                                    case "24":
                                        Console.WriteLine("enter id");
                                        UsersService.RemoveUser(Convert.ToInt32(Console.ReadLine()));

                                        break;
                                }
                                break;
                            case "3":
                                ProductService.GetAllProducts();
                                break;
                            case "4":
                                MemberService.AddToCart();
                                break;
                            case "5":
                                MemberService.ListsOfBasket();
                                break;
                            case "6":
                                MemberService.DoOrder();
                                break;
                            case "7":
                                MemberService.ListsOfOrdered();
                                break;
                            case "8":
                                //if (MemberService.CompleteOrder == false)
                                //{
                                //    MemberService.UnCompletedOrder();
                                //}
                                rol = Role.Default;
                                break;

                            default:
                                Console.WriteLine("Wrong Option.Please opt again.");
                                break;

                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                }

                    while (rol == Role.Member)
                    {
                        try
                        {
                            Console.WriteLine($"1. Mehsullara bax\n2. Sebete elave et\n3. Sebete bax\n4. Sifarisi tamamla\n5. Hesabdan cix");
                            string opt = Console.ReadLine();
                            switch (opt)
                            {
                                case "1":
                                    ProductService.GetAllProducts();
                                    break;
                                case "2":
                                    MemberService.AddToCart();
                                    break;
                                case "3":
                                    MemberService.ListsOfBasket();
                                    break;
                                case "4":
                                    MemberService.DoOrder();
                                    break;
                                case "5":
                                    //if (MemberService.CompleteOrder == false)
                                    //{
                                    //    MemberService.UnCompletedOrder();
                                    //}
                                    rol = Role.Default;
                                    break;
                                default:
                                    Console.WriteLine("Wrong Option.Please try again.");
                                    break;
                            }
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }

                    }
                }
            }
        }
    }
