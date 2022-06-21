
using MobilFinalYD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobilFinalYD.Data
{
    public static class Repo
    {
        
        public static List<Pet> Pets = new List<Pet>
        {
            new Pet {Id = 1 , Name = "Dog" , Image = "dog1.jpg" , Price = "100$"},
            new Pet {Id = 2 , Name = "Dog" , Image = "dog2.jpg" , Price = "150$"},
            new Pet {Id = 3 , Name = "Dog" , Image = "dog3.jpg" , Price = "160$"},
            new Pet {Id = 4 , Name = "Dog" , Image = "dog4.jpg" , Price = "170$"},
            new Pet {Id = 5 , Name = "Dog" , Image = "dog5.jpg" , Price = "185$"},

            new Pet {Id = 6 , Name = "Cat" , Image = "cat1.jpg" , Price = "20$"},
            new Pet {Id = 7 , Name = "Cat" , Image = "cat2.jpg" , Price = "40$"},
            new Pet {Id = 8 , Name = "Cat" , Image = "cat3.jpg" , Price = "30$"},
            new Pet {Id = 9 , Name = "Cat" , Image = "cat4.jpg" , Price = "50$"},
            new Pet {Id = 10 , Name = "Cat" , Image = "cat5.jpg" , Price = "65$"},

            new Pet {Id = 11 , Name = "Bird" , Image = "bird1.jpg" , Price = "20$"},
            new Pet {Id = 12 , Name = "Bird" , Image = "bird2.jpg" , Price = "15$"},
            new Pet {Id = 13 , Name = "Bird" , Image = "bird3.jpg" , Price = "25$"},
            new Pet {Id = 14 , Name = "Bird" , Image = "bird4.jpg" , Price = "50$"},
            new Pet {Id = 15 , Name = "Bird" , Image = "bird5.jpg" , Price = "120$"},

            new Pet {Id = 16 , Name = "Fish" , Image = "fish1.jpg" , Price = "10$"},
            new Pet {Id = 17 , Name = "Fish" , Image = "fish2.jpg" , Price = "7$"},
            new Pet {Id = 18 , Name = "Fish" , Image = "fish3.jpg" , Price = "5$"},
            new Pet {Id = 19 , Name = "Fish" , Image = "fish4.jpg" , Price = "3$"},
            new Pet {Id = 20 , Name = "Fish" , Image = "fish5.jpg" , Price = "12$"}
        };

        public static List<Product> Products = new List<Product>
        {
            new Product {Id= 1 , Age = 1 , Breed = "Dog" , Species = "Doberman" , Image = "dog1.jpg"},
            new Product {Id= 2 , Age = 2 , Breed = "Cat" , Species = "Maine Coon" , Image = "cat1.jpg"},
            new Product {Id= 3 , Age = 6 , Breed = "Fish" , Species = "Angle" , Image = "fish1.jpg"},
        };

        public static List<IncomeOrExpense> IncomeAndExpenses = new List<IncomeOrExpense>
        {
            new IncomeOrExpense {Name = "Patient", Cost="$35", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "25x Babies sold", Cost="$25", Image="moneybag1.jpg", IncomeFlag = true},
            new IncomeOrExpense {Name = "Food", Cost="$150", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "Airpump", Cost="$70", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "25x Babies sold", Cost="$25", Image="moneybag1.jpg", IncomeFlag = true},
            new IncomeOrExpense {Name = "Patient", Cost="$35", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "25x Babies sold", Cost="$25", Image="moneybag1.jpg", IncomeFlag = true},
            new IncomeOrExpense {Name = "Food", Cost="$150", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "Airpump", Cost="$70", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "25x Babies sold", Cost="$25", Image="moneybag1.jpg", IncomeFlag = true},
            new IncomeOrExpense {Name = "Patient", Cost="$35", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "25x Babies sold", Cost="$25", Image="moneybag1.jpg", IncomeFlag = true},
            new IncomeOrExpense {Name = "Food", Cost="$150", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "Airpump", Cost="$70", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "25x Babies sold", Cost="$25", Image="moneybag1.jpg", IncomeFlag = true},
            new IncomeOrExpense {Name = "Patient", Cost="$35", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "25x Babies sold", Cost="$25", Image="moneybag1.jpg", IncomeFlag = true},
            new IncomeOrExpense {Name = "Food", Cost="$150", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "Airpump", Cost="$70", Image="moneybag2.jpg", IncomeFlag = false},
            new IncomeOrExpense {Name = "25x Babies sold", Cost="$25", Image="moneybag1.jpg", IncomeFlag = true},
        };
        static Repo()
        {

        }
    }
}
