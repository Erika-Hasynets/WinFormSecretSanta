using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSecretSanta.Service
{
    internal class SantaService
    {
        struct User //Реєстрація
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        public struct People //Структура для введення даних по людей
        {
            public int id { get; set; }
            public string name { get; set; }
            public string lastname { get; set; }
        }
        public struct PresentTo //Потрібно для виявленя хто кому дарує
        {
            public int id { get; set; }
            public int presentToId { get; set; }
            public string name { get; set; }
            public string lastname { get; set; }
            public string presentToName { get; set; }
            public string presentToLastname { get; set; }
        }
        static void LoadOrCreateUserFile()
        {
            string FilePath = "users.json";
            if (!File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, "[]"); // Створити порожній JSON масив
            }
        }
        public bool startAutentification(string login, string password, int choice)
        {
            LoadOrCreateUserFile();


            switch (choice)
            {
                case 1:
                    bool isUser = Register(login, password);
                    return isUser;
                case 2:
                    isUser = Login(login, password);
                    return isUser;
            }
            return false;
        }
        static bool Register(string _login, string _password)
        {
            var users = GetUsers();

            var username = _login;
            var password = _password;

            //  Валідація пароля
            if (password.Length < 8 ||!password.Any(char.IsLetter) ||!password.Any(char.IsDigit))
            {
                // Невалідний пароль
                return false;
            }

            //  Перевірка чи вже існує такий користувач
            if (users.Exists(u => u.Username == username))
            {
                return false;
            }

            //  Створення нового користувача
            var newUser = new User
            {
                Username = username,
                Password = password
            };

            users.Add(newUser);
            SaveUsers(users);

            return true;
        }

        static bool Login(string _login, string _password)
        {
            var users = GetUsers();

           
            var login = _login;

         
            var password = _password;

            var user = users.Find(u => (u.Username == login) && u.Password == password);

            if (user.Username != login)
            {          
                return false;
            }
            else
            {
               
                return true;
            }
        }

        static List<User> GetUsers()
        {
            string FilePath = "users.json";
            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        static void SaveUsers(List<User> users)
        {
            string FilePath = "users.json";
            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
       
        public string[] ViewPeople(int currentIndex) //Потрібна для того, щоб можна було взаємодіяти і переглядати список людей.
        {
            string filePath = "data/People.json"; //шлях до файлу людей 


            List<People> people = LoadPeople(filePath); //Використовується для того, щоб записані люди потрапляли в змінну people

            if (people.Count == 0)
            {
                string[] error = new string[0];
                error[0] = "error";
                return error;
            }

            return DisplayPeople(people[currentIndex]);            
        }

        static string[] DisplayPeople(People people)//функція, яка відображає вписану структуру даних
        {
            string[] display = new string[3];
            
            display[0] = $" {people.id}";
            display[1] = $" {people.name}";
            display[2] = $" {people.lastname}";
            return display;
        }

        public string[] ViewPresent(int currentIndex) //фукнція, яка потрібна для показу результатів жеребкування
        {
            string filePath = "data/Present.json";

            List<PresentTo> present = LoadPresent(filePath); //завдяки цьому, результати жеребкування загружаються в змінну present.

            return DisplayPresentTo(present[currentIndex]);
        }

        static string[] DisplayPresentTo(PresentTo present) //фунція, завдяки якій відображаєшься результат жеребкування.
        {
            string[] result = new string[6];
            result[0] = $" {present.id}";
            result[1] = $" {present.name}";
            result[2] = $" {present.lastname}";
            result[3] = $" {present.presentToId}";
            result[4] = $" {present.presentToName}";
            result[5] = $" {present.presentToLastname}";
            return result;
        }


        public string addPeople(int _id, string _name, string _lastname)//додавання людей для жеребівки 
        {
            string filePath = "data/People.json";

            // Створення папки, якщо її не існує
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

            // Завантаження наявних даних
            List<People> PeopleList = new List<People>();
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    PeopleList = JsonSerializer.Deserialize<List<People>>(existingJson) ?? new List<People>();
                }
            }

            // Створення нового запису
            People myPeople = new People();

           
            if (PeopleList.Any(p => p.id == _id))
            {         
                return "error";
            }
            myPeople.id = _id;

                
            myPeople.name = _name;

                
            myPeople.lastname = _lastname;

                
            PeopleList.Add(myPeople);
            
            if (PeopleList.Count == 0)
            {     
                return "error";
            }
            // Збереження списку у файл
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(PeopleList, options);

            File.WriteAllText(filePath, json);

            return "Дані збережено у файл: " + filePath;
        }

        public string editPeople(int _id, string __name, string __lastname)
        {
            string filePath = "data/People.json";

            // Завантажуємо дані з файлу
            List<People> people = LoadPeople(filePath);

            int idToEdit = _id;

            // Змінюємо інформацію
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].id == idToEdit)
                {
                    string _name = __name;
                    string _lastname = __lastname;
                    people[i] = new People()
                    {
                        id = people[i].id,
                        name = _name,
                        lastname = _lastname
                    };
                    break;
                }
            }

            // Зберігаємо зміни у файл
            SavePeople(filePath, people);

            return "Дані успішно змінені!";
        }
        public string DeletePeople(int _id)
        {
            string filePath = "data/People.json";
            // Завантаження списку людей з JSON-файлу
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            List<People> people = LoadPeople(filePath);
            int id = _id;
            // Знаходження та видалення елемента з відповідним ID
            var peopleToRemove = people.Find(f => f.id == id);
            if (peopleToRemove.id == id)
            {
                people.Remove(peopleToRemove);

                // Збереження оновленого списку назад у файл
                string updatedJson = JsonSerializer.Serialize(people, options);
                File.WriteAllText(filePath, updatedJson);
                return $"людина із ID {id} видалено.";
            }
            else
            {
                return $"людина із ID {id} не знайдено.";
            }
        }
        public string DeleteAllPeople()//для видалення всіх людей
        {
            string filePath = "data/People.json";
            File.WriteAllText(filePath, string.Empty);
            return $"Файл {filePath} очищено.";
        }

        public string randomPresent() //Сама функція для відтворення жеребкування
        {
            string filePath = "data/People.json";
            string filePathPT = "data/Present.json";
            File.WriteAllText(filePathPT, "[]");
            // Завантажуємо дані з файлу
            List<People> people = LoadPeople(filePath);
            // Завантаження наявних даних
            List<PresentTo> PresentToList = new List<PresentTo>();
            if (File.Exists(filePathPT))
            {
                string existingJson = File.ReadAllText(filePathPT);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    PresentToList = JsonSerializer.Deserialize<List<PresentTo>>(existingJson) ?? new List<PresentTo>();
                }
            }

            Random random = new Random();

            for (int i = 0; i < people.Count; i++)
            {
                // Створення нового запису
                bool havePresent = false;
                PresentTo myPresent = new PresentTo();
                List<PresentTo> presentList = LoadPresent(filePathPT);
                myPresent.id = people[i].id;

                myPresent.presentToId = random.Next(1, people.Count + 1);
                for (int j = 0; j < presentList.Count; j++)
                {
                    if (presentList[j].presentToId == myPresent.presentToId)
                    {
                        havePresent = true;
                        break;
                    }
                }
                if (myPresent.id == myPresent.presentToId)
                {
                    havePresent = true;
                }
                if (havePresent == true)
                {
                    havePresent = false;
                    i--;
                    continue;
                }

                myPresent.name = people[i].name;
                myPresent.lastname = people[i].lastname;
                myPresent.presentToName = people[myPresent.presentToId - 1].name;
                myPresent.presentToLastname = people[myPresent.presentToId - 1].lastname;

                // Додавання нового запису до списку
                PresentToList.Add(myPresent);
                
                // Збереження списку у файл
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(PresentToList, options);    
                File.WriteAllText(filePathPT, json);
            }


            return "Дані збережено у файл: " + filePathPT;
        }

         static List<People> LoadPeople(string filePath)
        {
            if (!File.Exists(filePath)) return new List<People>();
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<People>>(json) ?? new List<People>();
        }
        public List<People> LoadPeoples(string filePath)
        {
            if (!File.Exists(filePath)) return new List<People>();
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<People>>(json) ?? new List<People>();
        }
        static void SavePeople(string filePath, List<People> people)
        {
            string json = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        static List<PresentTo> LoadPresent(string filePath)
        {
            if (!File.Exists(filePath)) return new List<PresentTo>();
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<PresentTo>>(json) ?? new List<PresentTo>();
        }
        public List<PresentTo> LoadPresents(string filePath)
        {
            if (!File.Exists(filePath)) return new List<PresentTo>();
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<PresentTo>>(json) ?? new List<PresentTo>();
        }
        static void SavePresent(string filePath, List<PresentTo> present)
        {
            string json = JsonSerializer.Serialize(present, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

       
        
    }
}
