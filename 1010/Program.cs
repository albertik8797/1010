namespace shop2
{
    internal class Program
    {
        public enum roule { администратор, кассир, кадровик, кладовщик, бухгалтер }
        public enum key { zerokey, UpArrow, DownArrow, LeftArrow, RightArrow, Escape, Enter, F1, F2, F10, S }
        static user curentuser;
        static List<user> logins = new List<user>();
        static List<people> peoplels = new List<people>();
        static List<goods> goodsss = new List<goods>();

        public struct user
        {
            public int id;
            public string login;
            public string password;
            public roule roule;
        }
        public struct people
        {
            public int id;
            public string famelename;
            public string name;
            public string fathername;
            public string numberpassport;
            public roule roule;
            public int salary;
        }
        public struct goods
        {
            public int id;
            public string name;
            public int cost;
            public int quantity;
        }
        internal interface Icrud
        {
            public void create();
            public void read();
            public void update();
            public void delete();
            public void find();
        }

        public class admin : Icrud
        {
            menu menuadm;
            public bool stupid()
            {
                Console.SetCursorPosition(Console.WindowLeft / 2, Console.WindowTop / 2);
                Console.WriteLine("Вы уверены y/n");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                } while ((cki.Key != ConsoleKey.Y) && (cki.Key != ConsoleKey.N));
                if (cki.Key != ConsoleKey.Y) { return true; } else { return false; }
            }

            public void create()
            {
                user adr = new user();
                menuadm.clearshow();
                Console.Write("login - "); adr.login = Console.ReadLine();
                Console.Write("password - "); adr.password = Console.ReadLine();
                Console.Write("roule (0-4) - "); ConsoleKeyInfo cki = Console.ReadKey();
                // adr.roule = (int)cki.KeyChar;
                throw new NotImplementedException();
            }

            public void read()
            {
                menuadm.clearshow();
                menuadm.usertolist(logins[menuadm.lastpos]);
                menuadm.show();

                //throw new NotImplementedException();
            }

            public void update()
            {
                menuadm.clearshow();
                menuadm.usertolist(logins[menuadm.lastpos]);
                if (menuadm.main() == 6)
                {
                    Console.SetCursorPosition(menuadm.startcol, menuadm.startrow + menuadm.newpos);
                    //logins[menuadm.newpos].[menuadm.lastpos] = Console.ReadLine();
                };

                //throw new NotImplementedException();
            }

            public void delete()
            {
                if (stupid())
                {
                    menuadm.clearshow();
                    logins.RemoveAt(menuadm.lastpos);
                    menuadm.userstolist();
                }

                //throw new NotImplementedException();
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public admin()
            {
                //inilog();
                Console.Clear();
                Console.WriteLine(curentuser.login);
                menuadm = new menu();
                int i;
                menuadm.userstolist();
                do
                {
                    i = menuadm.main();
                    switch (i)
                    {
                        case 5: break;//escape
                        case 6: read(); break;//enter (read)
                        case 7: create(); break;//f1
                        case 8: update(); break; //f2
                        case 9: delete(); break;
                        case 10: break;
                    }
                } while (i != 5);
            }
        }
        public class cashier : Icrud
        {
            public void create()
            {
                throw new NotImplementedException();
            }

            public void delete()
            {
                throw new NotImplementedException();
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                throw new NotImplementedException();
            }

            public void update()
            {
                throw new NotImplementedException();
            }
        }
        public class personnel : Icrud
        {
            menu menuadm;
            public bool stupid()
            {
                Console.SetCursorPosition(Console.WindowLeft / 2, Console.WindowTop / 2);
                Console.WriteLine("Вы уверены y/n");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                } while ((cki.Key != ConsoleKey.Y) && (cki.Key != ConsoleKey.N));
                if (cki.Key != ConsoleKey.Y) { return true; } else { return false; }
            }

            public void create()
            {
                people adr = new people();
                menuadm.clearshow();
                Console.Write("name - "); adr.name = Console.ReadLine();
                Console.Write("famelename - "); adr.famelename = Console.ReadLine();
                Console.Write("numberpassport - "); adr.numberpassport = Console.ReadLine();
                //Console.Write("salary - "); adr.salary = (int)Console.ReadLine();
                Console.Write("roule (0-4) - "); ConsoleKeyInfo cki = Console.ReadKey();
                // adr.roule = (int)cki.KeyChar;
                //throw new NotImplementedException();
            }

            public void delete()
            {
                if (stupid())
                {
                    menuadm.clearshow();
                    peoplels.RemoveAt(menuadm.lastpos);
                    menuadm.piplstolist();
                }

                // throw new NotImplementedException();
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                menuadm.clearshow();
                menuadm.usertolist(logins[menuadm.lastpos]);
                menuadm.show();

                // throw new NotImplementedException();
            }

            public void update()
            {
                throw new NotImplementedException();
            }
            public personnel()
            {
                //inilog();
                Console.Clear();
                Console.WriteLine(curentuser.login);
                menuadm = new menu();
                int i;
                menuadm.piplstolist();
                do
                {
                    i = menuadm.main();
                    switch (i)
                    {
                        case 5: break;//escape
                        case 6: read(); break;//enter (read)
                        case 7: create(); break;//f1
                        case 8: update(); break; //f2
                        case 9: delete(); break;
                        case 10: break;
                    }
                } while (i != 5);
            }

        }
        public class storekeeper : Icrud
        {
            menu menuadm;
            public bool stupid()
            {
                Console.SetCursorPosition(Console.WindowLeft / 2, Console.WindowTop / 2);
                Console.WriteLine("Вы уверены y/n");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                } while ((cki.Key != ConsoleKey.Y) && (cki.Key != ConsoleKey.N));
                if (cki.Key != ConsoleKey.Y) { return true; } else { return false; }
            }

            public void create()
            {
                goods adr = new goods();
                menuadm.clearshow();
                Console.Write("name - "); adr.name = Console.ReadLine();
                Console.Write("cost - "); adr.cost = 66;// (int)Console.ReadLine();
                Console.Write("quantity - "); adr.quantity = 540;// (int)Console.ReadLine();
                                                                 // adr.roule = (int)cki.KeyChar;
                                                                 // throw new NotImplementedException();
            }

            public void delete()
            {
                if (stupid())
                {
                    menuadm.clearshow();
                    goodsss.RemoveAt(menuadm.lastpos);
                    menuadm.goodsstolist();
                }

                // throw new NotImplementedException();
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                menuadm.clearshow();
                menuadm.goodstolist(goodsss[menuadm.lastpos]);
                menuadm.show();

                //throw new NotImplementedException();
            }

            public void update()
            {
                throw new NotImplementedException();
            }
            public storekeeper()
            {
                //inilog();
                Console.Clear();
                Console.WriteLine(curentuser.login);
                menuadm = new menu();
                int i;
                menuadm.goodsstolist();
                do
                {
                    i = menuadm.main();
                    switch (i)
                    {
                        case 5: break;//escape
                        case 6: read(); break;//enter (read)
                        case 7: create(); break;//f1
                        case 8: update(); break; //f2
                        case 9: delete(); break;
                        case 10: break;
                    }
                } while (i != 5);
            }

        }
        public class bookkeeper : Icrud
        {
            public void create()
            {
                throw new NotImplementedException();
            }

            public void delete()
            {
                throw new NotImplementedException();
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                throw new NotImplementedException();
            }

            public void update()
            {
                throw new NotImplementedException();
            }
        }
        public class login
        {
            string inputpass()
            {
                void backstar()
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write("*");
                }
                string esp = "";
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                    esp = esp + cki.KeyChar;
                    if (cki.Key != ConsoleKey.Enter)
                    {
                        backstar();
                    }

                } while ((cki.Key != ConsoleKey.Escape) && (cki.Key != ConsoleKey.Enter));

                if (cki.Key != ConsoleKey.Escape) { return esp; } else { return ""; }
            }

            public login()
            {
                user tempuser = new user();
                string tmp;
                tempuser.login = "";
                tempuser.password = "2";
                do
                {
                    Console.WriteLine("ввидите логин");
                    string log = Console.ReadLine();
                    foreach (user us in logins)
                    {
                        if (us.login == log) { tempuser = us; break; }
                    }
                    if (tempuser.login == "") { Console.Clear(); Console.WriteLine("неверный логин"); }
                } while (tempuser.login == "");
                do
                {
                    Console.WriteLine("ввидите пароль");
                    tmp = inputpass();
                } while (tempuser.password == tmp);
                curentuser = tempuser;
            }

        }
        public class menu
        {
            public int startcol = 10, startrow = 5;
            public int newpos, lastpos;
            string[] coun = new string[255];
            string[] couninfo = new string[255];
            private int arrcont = 0;
            public void show()
            {
                Console.SetCursorPosition(startcol - 3, startrow - 3);
                for (int i = 0; i < arrcont; i++)
                {
                    Console.SetCursorPosition(startcol, startrow + i);
                    Console.WriteLine(coun[i]);

                    Console.SetCursorPosition(startcol + 50, startrow + i);
                    Console.WriteLine(couninfo[i]);
                }
            }
            public void clearshow()
            {
                Console.SetCursorPosition(startcol - 3, startrow - 3);
                Console.WriteLine("                                                    ");

                for (int i = 0; i < arrcont; i++)
                {
                    Console.SetCursorPosition(startcol + 50, startrow + i);
                    Console.WriteLine("                                                                  ");
                }
            }

            private void showpos()
            {
                Console.SetCursorPosition(startcol - 3, startrow + lastpos);
                Console.Write(' ');

                Console.SetCursorPosition(startcol - 3, startrow + newpos);
                Console.Write('\u0010');

            }
            private int keyinfo()
            {
                ConsoleKeyInfo cki;
                Console.TreatControlCAsInput = true;
                int i = 0;
                do
                {
                    cki = Console.ReadKey();
                    switch (cki.Key)
                    {
                        case ConsoleKey.UpArrow: i = 1; break;
                        case ConsoleKey.DownArrow: i = 2; break;
                        case ConsoleKey.LeftArrow: i = 3; break;
                        case ConsoleKey.RightArrow: i = 4; break;
                        case ConsoleKey.Escape: i = 5; break;
                        case ConsoleKey.Enter: i = 6; break;
                        case ConsoleKey.F1: i = 7; break;
                        case ConsoleKey.F2: i = 8; break;
                        case ConsoleKey.F10: i = 9; break;
                        case ConsoleKey.S: i = 10; break;
                    }
                } while (i == 0);
                return i;
            }
            public int main()
            {
                // crud .....
                int i;
                show();
                showpos();
                do
                {
                    i = keyinfo();
                    //if (i != 5) { lastpos = newpos; }
                    switch (i)
                    {
                        case 1: newpos--; break;
                        case 2: newpos++; break;
                            //case 5: newpos++; break;
                    }
                    if (newpos > arrcont - 1) { newpos = 0; }
                    if (newpos < 0) { newpos = arrcont - 1; }
                    showpos();


                } while (i <= 4);
                return i;

            }
            public void userstolist()
            {
                arrcont = logins.Count;
                for (int i = 0; i < arrcont; i++)
                { coun[i] = logins[i].login; }
            }
            public void usertolist(user oh)
            {
                arrcont = 2;
                coun[0] = oh.id.ToString();
                coun[1] = oh.login;
                coun[2] = oh.password;
                //coun[3] = (string)roule[oh.roule];
            }
            public void piplstolist()
            {
                arrcont = peoplels.Count;
                for (int i = 0; i < arrcont; i++)
                { coun[i] = peoplels[i].famelename + " " + peoplels[i].name; }
            }
            public void pipltolist(people oh)
            {
                arrcont = 4;
                coun[0] = oh.id.ToString();
                coun[1] = oh.famelename;
                coun[2] = oh.name;
                coun[3] = oh.numberpassport;
                coun[4] = oh.salary.ToString();
                //coun[3] = (string)roule[oh.roule];
            }
            public void goodsstolist()
            {
                arrcont = goodsss.Count;
                for (int i = 0; i < arrcont; i++)
                { coun[i] = goodsss[i].name; }
            }
            public void goodstolist(goods oh)
            {
                arrcont = 4;
                coun[0] = oh.id.ToString();
                coun[1] = oh.name;
                coun[2] = oh.cost.ToString();
                coun[3] = oh.quantity.ToString();
            }

        }


        public static void shop()
        {
            user piple = new user();
            piple.id = 1;
            piple.login = "Админ";
            piple.password = "123";
            piple.roule = roule.администратор;

            logins.Add(piple);

            piple.id = 2;
            piple.login = "кассир";
            piple.password = "123";
            piple.roule = roule.кассир;

            logins.Add(piple);

            piple.id = 3;
            piple.login = "кадровик";
            piple.password = "123";
            piple.roule = roule.кадровик;

            logins.Add(piple);

            piple.id = 4;
            piple.login = "кладовщик";
            piple.password = "123";
            piple.roule = roule.кладовщик;

            logins.Add(piple);

            piple.id = 5;
            piple.login = "бухгалтер";
            piple.password = "123";
            piple.roule = roule.бухгалтер;

            logins.Add(piple);

            people men = new people();
            men.fathername = "Попова";
            men.name = "Мaрия";
            men.fathername = "Александровна";
            men.numberpassport = "4520 678432";
            men.salary = 45000;
            peoplels.Add(men);

            goods god = new goods();
            god.name = "Помидоры";
            god.cost = 10;
            god.quantity = 1;
            goodsss.Add(god);
            god.name = "Мангал";
            god.cost = 699;
            god.quantity = 1;
            goodsss.Add(god);
            god.name = "маринованные шашлыки";
            god.cost = 899;
            god.quantity = 69;
            goodsss.Add(god);
            god.name = "спички";
            god.cost = 6;
            god.quantity = 540;
            goodsss.Add(god);

            login loginbly = new();
            if (curentuser.roule == roule.администратор) { admin adm = new admin(); }
            if (curentuser.roule == roule.кадровик) { personnel adm = new personnel(); }
            if (curentuser.roule == roule.кладовщик) { storekeeper adm = new storekeeper(); }

        }

        static void Main(string[] args)
        {
            shop();
        }
    }
}
/*Практическая 10 - Информационная система - магазин
Необходимо в консоли реализовать информационную систему. 
Информационная система - любое предприятие (например, магазин, it-компания, кафе и прочее). 
Задание будет рассматриваться на примере магазина
----------------------------------------------
Необходимый общий функционал:

ИС должна состоять из 5 должностей - администратор, кассир, менеджер персонала (кадровик),
склад-менеджер, бухгалтер Между этими ролями должна быть авторизация - администратор под
администратором, кассир под кассиром и т.п.. Приложение должно начинаться с авторизации. 
Условия авторизации:
-- Пароль при авторизации должен быть скрыт звездочками
-- Должна быть возможность повторного ввода логина и пароля 
(если я ввела что-то не так, у меня должна быть возможность поменять это)
После авторизации должен быть вывод логина, за которым пользователь авторизовался. 
Если этот пользователь привязан к сотруднику (см. функционал менеджера персонала), 
вместо логина должно отображаться имя сотрудника
Должна быть защита от дураков (неправильный ввод, неверный пароль, несуществующий пользователь и т.п.)
Выход из каждого меню на уровень выше должен быть реализован по нажатию на клавишу Escape 
(из меню дополнительной информации в меню пунктов, из меню пунктов в авторизацию и т.п.)
Дальнейший функционал разделяется по ролям
Администратор:
При открытии меню администратора показываются все пользователи системы
Должна быть возможность выбрать один из выведенных пунктов и посмотреть подробную информацию. 
Выбор пунктов должен быть выполнен через стрелочное меню
Должны быть реализованы CRUD операции (добавление - create, чтение - read, изменение - update, 
удаление - delete) пользователей системы. За отсутствие одной из 4 операций пункт засчитан не будет
Должен быть реализован поиск по всем атрибутам пользователя системы. Пункт, по которому нужно искать,
необходимо выбирать. За отсутствие поиска по одному из атрибутов пункт засчитан не будет
При создании и изменении должна быть возможность повторного ввода данных 

(если я ввела что-то не так, у меня должна быть возможность поменять это)
Все данные должны быть сохранены в JSON или XML файл, чтобы пользователь смог даже после выхода 
из системы или выхода из программы вернуться повторно к этим данным
Менеджер персонала:
При открытии меню менеджера персонала показываются все сотрудники
Должна быть возможность выбрать один из выведенных пунктов и посмотреть подробную информацию. 
Выбор пунктов должен быть выполнен через стрелочное меню
Должны быть реализованы CRUD операции (добавление - create, чтение - read, изменение - update, 
удаление - delete) сотрудников. За отсутствие одной из 4 операций пункт засчитан не будет
Должен быть реализован поиск по всем атрибутам сотрудника. Пункт, по которому нужно искать, 
необходимо выбирать. За отсутствие поиска по одному из атрибутов пункт засчитан не будет
При создании и изменении должна быть возможность привязать сотрудника к пользователю системы. 
По умолчанию, сотрудник сам по себе, пользователь сам по себе. Если при создании или изменении ввести
ID пользователя, сотрудник будет привязан к этому пользователю. Несколько сотрудников нельзя 
привязать к одному пользователю. Привязка влияет на отображение имени при авторизации (см. последний 
пункт в основном функционале)
При создании и изменении должна быть возможность повторного ввода данных  (если я ввела что-то не так,
у меня должна быть возможность поменять это)
Все данные должны быть сохранены в JSON или XML файл, чтобы пользователь смог даже после выхода 
из системы или выхода из программы вернуться повторно к этим данным
Склад-менеджер:
При открытии меню склада показываются все товары
Должна быть возможность выбрать один из выведенных пунктов и посмотреть подробную информацию. 
Выбор пунктов должен быть выполнен через стрелочное меню
Должны быть реализованы CRUD операции (добавление - create, чтение - read, изменение - update, 
удаление - delete) товаров на складе. За отсутствие одной из 4 операций пункт засчитан не будет
Должен быть реализован поиск по всем атрибутам товара. Пункт, по которому нужно искать, необходимо 
выбирать. За отсутствие поиска по одному из атрибутов пункт засчитан не будет
При создании и изменении должна быть возможность повторного ввода данных  (если я ввела что-то не 
так, у меня должна быть возможность поменять это)
Все данные должны быть сохранены в JSON или XML файл, чтобы пользователь смог даже после выхода 
из системы или выхода из программы вернуться повторно к этим данным
Кассир:
При открытии меню кассы показываются все товары из склада
Должна быть возможность выбрать один из выведенных товаров. Выбор пунктов должен быть выполнен 
через стрелочное меню
В выборе пунктов по нажатию клавиш + и - должно идти добавление или убавление товара в чек
Нельзя добавить товара больше, чем его есть на складе. Нельзя добавить товара меньше нуля
По нажатию на клавишу S заказ должен завершиться и обнулить все количество выбранных элементов для 
будущего заказа
После завершения заказа все купленные элементы должны быть вытчены из склада (На складе было 10 
коробок, я купила 3 через кассу, на складе осталось 7 коробок)
После завершения заказа все купленные элементы должны учитываться в бухгалтерии 
(Я купила 3 коробки за 300 рублей, в бухгалтерию идет запись о прибыли 300 рублей)
После завершения заказа, данные об измененном складе и измененной бухгалтерии должны быть 
сохранены в JSON или XML файл, чтобы пользователь смог даже после выхода из системы или выхода 
из программы вернуться повторно к этим данным
Бухгалтер:
При открытии меню бухгалтера показываются все записи о денежных транзакциях
Должна быть возможность выбрать один из выведенных пунктов и посмотреть подробную информацию. 
Выбор пунктов должен быть выполнен через стрелочное меню
Должны быть реализованы CRUD операции (добавление - create, чтение - read, изменение - update, 
удаление - delete) записей бухгалтерии. За отсутствие одной из 4 операций пункт засчитан не будет
Должен быть реализован поиск по всем атрибутам записей бухгалтерии. Пункт, по которому нужно искать, 
необходимо выбирать. За отсутствие поиска по одному из атрибутов пункт засчитан не будет
При создании и изменении должна быть возможность повторного ввода данных  (если я ввела что-то не
так, у меня должна быть возможность поменять это)
Все данные должны быть сохранены в JSON или XML файл, чтобы пользователь смог даже после выхода
из системы или выхода из программы вернуться повторно к этим данным
----------------------------------------------
Необходимая структура:
Логика для пяти ролей должна быть в пяти отдельных обычных классах. 
Внутри классов с логикой должен быть конструктор, выполняющий первоначальную настройку роли 
(десериализация данных, отображение меню, вывод имени авторизированного пользователя и т.п.)
Классы должны наследовать интерфейс с CRUD операциями - (добавление - create, чтение - read, 
изменение - update, удаление - delete) + поиск. Остальные методы в интерфейсе по желанию. 
Примечание: у кассира необязателен этот интерфейс, так как внутри кассира нет изменения и поиска
Для сохранения данных пользователей, сотрудников, товаров, выбранных товаров на кассе и записей 
в бухгалтерии должны быть свои типы данных
-- Пользователь должен состоять из: ID, Логин, Пароль, Роль
-- Сотрудник должен состоять из: ID, Фамилия, Имя, Отчество (по умолчанию пусто), 
Дата рождения, Серия номер паспорта, Должность, Зарплата, ID пользователя (для привязки)
-- Товар должен состоять из: ID, Название, Цена за штуку, Количество на складе 
-- Выбранный товар на кассе должен состоять из: ID, Название, Цена за штуку, Количество на складе, 
Выбранное количество. Выбранный товар должен наследовать тип данных "Товар", чтобы не повторять одни
и те же атрибуты
-- Запись бухгалтерии должна состоять из: ID, Название, Сумма денег, Дата записи, Приход или вычет 
(добавить ли деньги или вычесть их)
Роли пользователя должны быть реализованы через enum. Системные клавиши для стрелочного меню 
(F1, Escape, F2, F10, S и прочее) должны быть реализованы через enum
Для сериализации и десериализации должен быть отдельный статический класс. Внутри него должно быть 
только два метода - сериализация и десериализация. Не должно быть разных методов для разных типов 
данных
Данные должны сохраняться в системной папке (рабочий стол, документы, изображения и прочее) 
вне зависимости от того, на каком компьютере находится программа
Должен быть отдельный обычный или статический класс для авторизации пользователя. 

ВНИМАНИЕ: За отсутствие хотя бы одной из пяти ролей оценки выше 3 не будет. Если вы пропустите 
эту практическую, автомат засчитан не будет
Оценка 2 начинается от выполнения 10 пунктов
В случае невыполнения или пропуска 10 работы автомата не будет - вам нужно будет на зачете
отвечать на вопросы и реализовать маленькую программу
За каждый невыполненный пункт 0.1 балл. Меньше 2 оценки быть не может */