namespace Model
{
    public interface INamed
    {
        string Name { get; set; }
    }

    public class Person : INamed  //Человек
    {
        public string Name { get; set; }    //Имя
        public int Age { get; set; }        //Возраст
    }

    public abstract class BaseBook : INamed
    {
        public string Title { get; set; }  //Название
        public double Price { get; set; } //Цена
        public string Name
        {
            get { return Title; }
            set { Title = value; }
        }
    }

    public class Book : BaseBook   //Книга
    {
    }
    public class EBook : BaseBook  //Книга
    {
    }

    public class Magazine : INamed
    {
        public string Name { get; set; }
    }
}