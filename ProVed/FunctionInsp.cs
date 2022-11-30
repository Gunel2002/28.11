using System;

namespace InspectorLib
{
    public class FunctionInsp
    {
        string[] fullName = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." }; //список ФИО сотрудников
        string leaderFullName; //ФИО главного инспектора
        string inspectionName = "Автоинспекция г. Чита"; //название автоинспекции
        public FunctionInsp() => leaderFullName = fullName[fullName.Length - 1];
        public string GetInspector()
        {
            return leaderFullName;
        } //возвращает ФИО главного Инспектора
        public string GetCarInspection()
        {
            return inspectionName;
        } //возвращает название автоинспекции
        public void SetInspector(string fullName)
        {
            int i;
            try
            {
                i = Array.IndexOf(this.fullName, fullName);
                if (this.fullName[i] == fullName) throw new IndexOutOfRangeException();
                this.leaderFullName = fullName;
                Console.WriteLine("ФИО главного инспектора измененно");
            }
            catch
            {
                Console.WriteLine("ФИО главного инспектора не удалось изменить");
            }
        } //изменяет ФИО главного инспектора
        public string GenerateNumber(int number, char symbol, int code = 75)
        {
            string result = symbol + "";
            result = result.ToUpper() + "" + number + "_" + code;
            return result;
        } //генерация госномера
        public string GetWorker()
        {
            string worker = "";
            for (int i = 0; i < fullName.Length; i++)
                worker += (fullName[i] + ", ");
            return worker;
        } //возвращает список всех сотрудников
        public void AddWorker()
        {
            Console.WriteLine("Введите ФИО нового сотрудника");
            string fn = Console.ReadLine();
            Array.Resize(ref fullName, fullName.Length + 1);
            fullName[fullName.Length - 1] = fn;
            Console.WriteLine($"Cотрудник {fn} успешно добавлен");
        } //добавляет нового сотрудника
    }
}
