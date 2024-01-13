using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.AccessControl;
namespace Test
{
    public interface Appearance // interface class for methods setFace, setEye, setBody, and setClothes
    {
        void setFace();
        void setEye();
        void setBody();
        void setClothes();
    }
    public abstract class Hair //abstract class for setHair
    {
        public abstract void setHair(); //abstract method named setHair
    }
    public struct playerStats
    {
        public int Vigor;
        public int Endurance;
        public int Agility;
    }
    public class Categories : Hair, Appearance //implementing the abstract class Hair and interface class Appearance
    {
        private string name, genderString, faceString, hairStyleString, hairColorString, eyeShapeString, skinColorString, bodyTypeString, underGarString, ClothesString, cosmeticsString, TattooString, PiercingString, ProstheticsString, ScarsString, AccessoriesString, JobString, weapTypeString;
        private playerStats stats;
        private bool storyMode = true;
        private SetVoice setVoice;

        public Categories(SetVoice setVoice) //constructor for default values
        {
            genderString = "Unknown";
            faceString = "Unknown";
            hairStyleString = "Unknown";
            hairColorString = "Unknown";
            eyeShapeString = "Unknown";
            skinColorString = "Unknown";
            bodyTypeString = "Unknown";
            underGarString = "Unknown";
            ClothesString = "Unknown";
            cosmeticsString = "Unknown";
            TattooString = "Unknown";
            PiercingString = "Unknown";
            ProstheticsString = "Unknown";
            ScarsString = "Unknown";
            AccessoriesString = "Unknown";
            this.setVoice = setVoice;
            JobString = "Unknown";
            weapTypeString = "Unknown";
            name = "Unknown";
        }

        public void setGender()
        {
            string[] Gender = { "Male", "Female", "Others" };
            bool validChoice = false;
            int choice = 0;

            Console.WriteLine("\nChoose your Gender:");

            while (!validChoice)
            {
                for (int i = 0; i < Gender.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Gender[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= Gender.Length)
                    {
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            genderString = Gender[choice - 1];
            Console.WriteLine($"Gender: {genderString}"); //This will show the choice of the user

        }
        public void setFace() //implementation of the method setFace in the interface Appearance
        {
            string[] Face = { "Square", "Round", "Oval", "Rectangle" };
            bool validChoice = false;
            int choice = 0;

            Console.WriteLine("\nChoose your Face:");

            while (!validChoice)
            {
                for (int i = 0; i < Face.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Face[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= Face.Length)
                    {
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            faceString = Face[choice - 1];
            Console.WriteLine($"Face: {faceString}"); //This will show the choice of the user

        }
        public override void setHair() //with the use of override keyword, we can now provide specific implementations to the abstract method setHair()
        {
            string[] hairStyle = { "Braids", "Pompadour", "Long Layers", "Undercut" };
            bool validChoice = false;
            int choice = 0;

            Console.WriteLine("\nChoose your Hair Style:");

            while (!validChoice)
            {
                for (int i = 0; i < hairStyle.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {hairStyle[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= hairStyle.Length)
                    {
                        hairStyleString = hairStyle[choice - 1];
                        Console.WriteLine($"Hair Style: {hairStyleString}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            validChoice = false;

            string[] hairColor = { "Black", "White", "Red", "Blonde" };
            Console.WriteLine("\nChoose your Hair Color:");

            while (!validChoice)
            {
                for (int i = 0; i < hairColor.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {hairColor[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 >= 1 && choice2 <= hairColor.Length)
                    {
                        hairColorString = hairColor[choice2 - 1];
                        Console.WriteLine($"Hair Color: {hairColorString}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public void setEye() //implementation of the method setEye in the interface Appearance
        {
            string[] eyeShape = { "Rounded", "Asian", "Droopy", "Almond" };
            bool validChoice = false;
            int choice = 0;

            Console.WriteLine("\nChoose your Eyes:");

            while (!validChoice)
            {
                for (int i = 0; i < eyeShape.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {eyeShape[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= eyeShape.Length)
                    {
                        eyeShapeString = eyeShape[choice - 1];
                        Console.WriteLine($"Eyes: {eyeShapeString}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public void setBody() //implementation of the method setBody in the interface Appearance
        {
            string[] skinColor = { "Brown", "White", "Black", "Yellow" };
            bool validChoice = false;
            int choice = 0;

            Console.WriteLine("\nChoose your Skin Color:");

            while (!validChoice)
            {
                for (int i = 0; i < skinColor.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {skinColor[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= skinColor.Length)
                    {
                        skinColorString = skinColor[choice - 1];
                        Console.WriteLine($"Skin Color: {skinColorString}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            validChoice = false;

            string[] bodyType = { "Slim", "Well-toned", "Slender", "Fat" };
            Console.WriteLine("\nChoose your Body Type:");

            while (!validChoice)
            {
                for (int i = 0; i < bodyType.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {bodyType[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 >= 1 && choice2 <= bodyType.Length)
                    {
                        bodyTypeString = bodyType[choice2 - 1];
                        Console.WriteLine($"Body Type: {bodyTypeString}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public void setClothes() //implementation of the method setClothes in the interface Appearance
        {
            string[] underGar = { "Two Piece", "One Piece" };
            bool validChoice = false;
            int choice = 0;

            Console.WriteLine("\nChoose your Undergarment:");

            while (!validChoice)
            {
                for (int i = 0; i < underGar.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {underGar[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= underGar.Length)
                    {
                        underGarString = underGar[choice - 1];
                        Console.WriteLine($"Undergarment: {underGarString}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            validChoice = false;

            string[] Clothes = { "Silk", "Wool", "Leather" };
            Console.WriteLine("\nChoose your Clothes:");

            while (!validChoice)
            {
                for (int i = 0; i < Clothes.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Clothes[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 >= 1 && choice2 <= Clothes.Length)
                    {
                        ClothesString = Clothes[choice2 - 1];
                        Console.WriteLine($"Clothes: {ClothesString}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public void setOthers()
        {
            // 1ST
            string[] Cosmetics = { "Blush", "Highlighter", "Eyeshadows" };
            bool validChoice1 = false;
            int choice1 = 0;

            Console.WriteLine("\nChoose your Cosmetics:");

            while (!validChoice1)
            {
                for (int i = 0; i < Cosmetics.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Cosmetics[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice1 = Convert.ToInt32(Console.ReadLine());

                    if (choice1 >= 1 && choice1 <= Cosmetics.Length)
                    {
                        cosmeticsString = Cosmetics[choice1 - 1];
                        Console.WriteLine($"Cosmetics: {cosmeticsString}");
                        validChoice1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            // 2ND
            string[] Tattoo = { "Full sleeves", "Traditional", "Japanese Style" };
            bool validChoice2 = false;
            int choice2 = 0;

            Console.WriteLine("\nChoose your Tattoo:");

            while (!validChoice2)
            {
                for (int i = 0; i < Tattoo.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Tattoo[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 >= 1 && choice2 <= Tattoo.Length)
                    {
                        TattooString = Tattoo[choice2 - 1];
                        Console.WriteLine($"Tattoo: {TattooString}");
                        validChoice2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            // 3RD
            string[] Piercing = { "Septum", "Lobe", "Nipple", "Belly Button" };
            bool validChoice3 = false;
            int choice3 = 0;

            Console.WriteLine("\nChoose your Piercing:");

            while (!validChoice3)
            {
                for (int i = 0; i < Piercing.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Piercing[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice3 = Convert.ToInt32(Console.ReadLine());

                    if (choice3 >= 1 && choice3 <= Piercing.Length)
                    {
                        PiercingString = Piercing[choice3 - 1];
                        Console.WriteLine($"Piercing: {PiercingString}");
                        validChoice3 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            // 4TH
            string[] Prosthetics = { "Right Arm", "Left Arm", "Right Leg", "Left Leg" };
            bool validChoice4 = false;
            int choice4 = 0;

            Console.WriteLine("\nChoose your Prosthetics:");

            while (!validChoice4)
            {
                for (int i = 0; i < Prosthetics.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Prosthetics[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice4 = Convert.ToInt32(Console.ReadLine());

                    if (choice4 >= 1 && choice4 <= Prosthetics.Length)
                    {
                        ProstheticsString = Prosthetics[choice4 - 1];
                        Console.WriteLine($"Prosthetics: {ProstheticsString}");
                        validChoice4 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            // 5TH
            string[] Scars = { "Arms", "Legs", "Face", "Torso" };
            bool validChoice5 = false;
            int choice5 = 0;

            Console.WriteLine("\nChoose your Scars:");

            while (!validChoice5)
            {
                for (int i = 0; i < Scars.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Scars[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice5 = Convert.ToInt32(Console.ReadLine());

                    if (choice5 >= 1 && choice5 <= Scars.Length)
                    {
                        ScarsString = Scars[choice5 - 1];
                        Console.WriteLine($"Scars: {ScarsString}");
                        validChoice5 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            // 6TH
            string[] Accessories = { "Rings", "Necklaces", "Hats", "Bracelets" };
            bool validChoice6 = false;
            int choice6 = 0;

            Console.WriteLine("\nChoose your Accessories:");

            while (!validChoice6)
            {
                for (int i = 0; i < Accessories.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Accessories[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice6 = Convert.ToInt32(Console.ReadLine());

                    if (choice6 >= 1 && choice6 <= Accessories.Length)
                    {
                        AccessoriesString = Accessories[choice6 - 1];
                        Console.WriteLine($"Accessories: {AccessoriesString}");
                        validChoice6 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public void setJob()
        {
            string[] Job = { "Thief", "Paladin", "Druid", "Priest", "Hunter" };
            bool validChoice = false;
            int choice = 0;

            Console.WriteLine("\nChoose your Job/Profession:");

            while (!validChoice)
            {
                for (int i = 0; i < Job.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Job[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= Job.Length)
                    {
                        JobString = Job[choice - 1];
                        Console.WriteLine($"Job/Profession: {JobString}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            validChoice = false;

            string[] weapType = { "Sword", "Axe", "Polearm", "Spear", "Dagger", "Bow", "Staff", "Ak47" };
            Console.WriteLine("\nChoose your Weapon:");

            while (!validChoice)
            {
                for (int i = 0; i < weapType.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {weapType[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 >= 1 && choice2 <= weapType.Length)
                    {
                        weapTypeString = weapType[choice2 - 1];
                        Console.WriteLine($"Weapon: {weapTypeString}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public void setStats()
        {
            int[] Vigor = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] Endurance = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] Agility = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            bool validChoice = false;

            // Vigor
            while (!validChoice)
            {
                Console.Write("\nChoose your Starting Vigor (HP) [1 - 9]: ");
                try
                {
                    int vigorChoice = Convert.ToInt32(Console.ReadLine());

                    if (vigorChoice >= 1 && vigorChoice <= Vigor.Length)
                    {
                        stats.Vigor = Vigor[vigorChoice - 1];
                        Console.WriteLine($"Vigor: {stats.Vigor}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            validChoice = false;

            // Endurance
            while (!validChoice)
            {
                Console.Write("\nChoose your Starting Endurance (Stamina) [1 - 9]: ");
                try
                {
                    int EnduranceChoice = Convert.ToInt32(Console.ReadLine());

                    if (EnduranceChoice >= 1 && EnduranceChoice <= Endurance.Length)
                    {
                        stats.Endurance = Endurance[EnduranceChoice - 1];
                        Console.WriteLine($"Endurance: {stats.Endurance}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            validChoice = false;

            // Agility
            while (!validChoice)
            {
                Console.Write("\nChoose your Starting Agility (Speed/Movement) [1 - 9]: ");
                try
                {
                    int AgilityChoice = Convert.ToInt32(Console.ReadLine());

                    if (AgilityChoice >= 1 && AgilityChoice <= Agility.Length)
                    {
                        stats.Agility = Agility[AgilityChoice - 1];
                        Console.WriteLine($"Agility: {stats.Agility}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public string GetName() //retrieving the value of name
        {
            return name;
        }

        public void SetName(string newName) // modifying the value of name
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
            }
            else
            {
                Console.WriteLine("Name cannot be empty!");
            }
        }
        public bool IsNameTaken()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\XTOFF\ONEDRIVE\DESKTOP\TPCOMPROG\TPCOMPROG\DATABASE1.MDF;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string CheckQuery = "SELECT COUNT (*) FROM Testing WHERE Name = @Name";
                using (SqlCommand command = new SqlCommand(CheckQuery, connection)) { 
                command.Parameters.AddWithValue("@name", name);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public void setName() // modifying the value of name by user input
        {
            Console.Write("\nName: ");
            string inputName = Console.ReadLine();
            SetName(inputName);
            IsNameTaken();
        }
        public void setMode()
        {
            bool validChoice = false;
            char userDes = ' ';

            while (!validChoice)
            {
                Console.Write("Continue to Story Mode[Y] or Skip[N]? ");

                try
                {
                    userDes = Console.ReadKey().KeyChar;
                    Console.WriteLine(); // Move to the next line after reading the key

                    if (userDes == 'Y' || userDes == 'y')
                    {
                        PrintStoryOutput(true);
                        validChoice = true;
                    }

                    else if (userDes == 'N' || userDes == 'n')
                    {
                        storyMode = false;
                        PrintStoryOutput();
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please enter 'Y' to continue or 'N' to skip.\nCurrent Story Mode: " + storyMode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public void PrintStoryOutput(bool continueStory)
        {
            Console.WriteLine("\n\nYou awaken on a cold, worn-down Imperial wagon, bound and gagged, as it winds its way through a snowy mountain pass. Snow-capped peaks and pine forests loom around you in this very cold and harsh atmosphere.\r\n\r\nYou're caught in the middle of the escalating civil war between the Empire and the rebels. Your comrades urge you to join forces with him during the escape that's about to unfold.\r\n\r\nYou arrived at the unknown fort, placed at the foot of the mountains. As they force you to long, growling march towards your execution for accused treason. Suddenly, a dragon attacks the town, providing chaos and an opportunity for you to escape. Now fight your way out!");
        }
        public void PrintStoryOutput()
        {
            Console.WriteLine("Skipping the story...");
        }
        public void PrintOutput(SetVoice setBoses)
        {
            Console.WriteLine("\n\nCharacter Rundown\n");
            Console.WriteLine($"Gender: {this.genderString}");
            Console.WriteLine($"\nFace: {this.faceString}");
            Console.WriteLine($"Hair Style: {this.hairStyleString}");
            Console.WriteLine($"Hair Color: {this.hairColorString}");
            Console.WriteLine($"Eye: {this.eyeShapeString}");
            Console.WriteLine($"\nSkin Color: {this.skinColorString}");
            Console.WriteLine($"Body: {this.bodyTypeString}");
            Console.WriteLine($"\nUndergarment: {this.underGarString}");
            Console.WriteLine($"Clothes: {this.ClothesString}");
            Console.WriteLine($"\nCosmetics: {this.cosmeticsString}");
            Console.WriteLine($"Tattoo: {this.TattooString}");
            Console.WriteLine($"Piercing: {this.PiercingString}");
            Console.WriteLine($"Prosthetics: {this.ProstheticsString}");
            Console.WriteLine($"Scars: {this.ScarsString}");
            Console.WriteLine($"Accessories: {this.AccessoriesString}");
            Console.WriteLine($"Voice: {setBoses.voiceChoice}, Sound: {setBoses.voiceSound}");
            Console.WriteLine($"\nJob: {this.JobString}");
            Console.WriteLine($"Weapon {this.weapTypeString}");
            Console.WriteLine($"\nVigor(HP): {stats.Vigor}");
            Console.WriteLine($"Endurance(Stamina): {stats.Endurance}");
            Console.WriteLine($"Agility(Speed/Movement): {stats.Agility}");
            Console.WriteLine($"\nName: {this.name}");
            Console.WriteLine($"\nStory Mode: {this.storyMode}");
        }
        public void InsertIntoDatabase(SetVoice setBoses)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\XTOFF\ONEDRIVE\DESKTOP\TPCOMPROG\TPCOMPROG\DATABASE1.MDF;Integrated Security=True;";

            string insertQueryString = "INSERT INTO Testing (Gender, Face, Hair_Style, Hair_Color, Eye_Type, Skin_Color, Body, Undergarment, Clothes, Cosmetics, Tattoo, Piercing, Prosthetics, Scars, Accessories, Voice, Job, Weapon, Vigor, Endurance, Agility, Name, Story_Mode) VALUES (@Gender, @Face, @HairStyle, @HairColor, @Eye, @SkinColor, @Body, @Undergarment, @Clothes, @Cosmetics, @Tattoo, @Piercing, @Prosthetics, @Scars, @Accessories, @Voice, @Job, @Weapon, @Vigor, @Endurance, @Agility, @Name, @StoryMode)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQueryString, connection))
                {
                    command.Parameters.AddWithValue("@Gender", this.genderString);
                    command.Parameters.AddWithValue("@Face", this.faceString);
                    command.Parameters.AddWithValue("@HairStyle", this.hairStyleString);
                    command.Parameters.AddWithValue("@HairColor", this.hairColorString);
                    command.Parameters.AddWithValue("@Eye", this.eyeShapeString);
                    command.Parameters.AddWithValue("@SkinColor", this.skinColorString);
                    command.Parameters.AddWithValue("@Body", this.bodyTypeString);
                    command.Parameters.AddWithValue("@Undergarment", this.underGarString);
                    command.Parameters.AddWithValue("@Clothes", this.ClothesString);
                    command.Parameters.AddWithValue("@Cosmetics", this.cosmeticsString);
                    command.Parameters.AddWithValue("@Tattoo", this.TattooString);
                    command.Parameters.AddWithValue("@Piercing", this.PiercingString);
                    command.Parameters.AddWithValue("@Prosthetics", this.ProstheticsString);
                    command.Parameters.AddWithValue("@Scars", this.ScarsString);
                    command.Parameters.AddWithValue("@Accessories", this.AccessoriesString);
                    command.Parameters.AddWithValue("@Voice", setBoses.voiceChoice);
                    command.Parameters.AddWithValue("@job", this.JobString);
                    command.Parameters.AddWithValue("@Weapon", this.weapTypeString);
                    command.Parameters.AddWithValue("@Vigor", stats.Vigor);
                    command.Parameters.AddWithValue("@Endurance", stats.Endurance);
                    command.Parameters.AddWithValue("@Agility", stats.Agility);
                    command.Parameters.AddWithValue("@Name", this.name);
                    command.Parameters.AddWithValue("@StoryMode", this.storyMode);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DisplayExistingCharacters(string connectionString)
        {
            string query = "SELECT * FROM Testing";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nExisting Characters:");
                        Console.WriteLine("====================");

                        while (reader.Read())
                        {
                            int Id = Convert.ToInt32(reader["Id"]);
                            string gender = reader["Gender"].ToString();
                            string face = reader["Face"].ToString();
                            string hairstyle = reader["Hair_Style"].ToString();
                            string haircolor = reader["Hair_Color"].ToString();
                            string eyetype = reader["Eye_Type"].ToString();
                            string skincolor = reader["Skin_Color"].ToString();
                            string body = reader["Body"].ToString();
                            string undergarment = reader["Undergarment"].ToString();
                            string clothes = reader["Clothes"].ToString();
                            string cosmetics = reader["Cosmetics"].ToString();
                            string tattoo = reader["Tattoo"].ToString();
                            string piercing = reader["Piercing"].ToString();
                            string prosthetics = reader["Prosthetics"].ToString();
                            string scars = reader["Scars"].ToString();
                            string Accessories = reader["Accessories"].ToString();
                            string voice = reader["Voice"].ToString();
                            string job = reader["job"].ToString();
                            string weapon = reader["Weapon"].ToString();
                            string vigor = reader["Vigor"].ToString();
                            string endurance = reader["Endurance"].ToString();
                            string agility = reader["Agility"].ToString();
                            string name = reader["Name"].ToString();
                            string storymode = reader["Story_Mode"].ToString();



                            Console.WriteLine($"\nID: {Id} \nGender: {gender} \nFace: {face} \nHair Style: {hairstyle} \nHair Color: {haircolor} \nEye: {eyetype} \nSkin Color: {skincolor} \nBody Color: {body} \nUndergarment: {undergarment} \nClothes: {clothes} \nCosmetics: {cosmetics} \nTattoo: {tattoo} \nPiercing: {piercing} \nProsthetics: {prosthetics} \nScars: {scars} \nAccessories: {Accessories} \nVoice: {voice} \njob: {job} \nWeapon: {weapon} \nVigor: {vigor} \nEndurance: {endurance} \nAgility: {agility} \nName: {name} \nStory Mode {storymode}");
                        }
                    }
                }
            }
        }

        public void DisplaySelectedCharacter(string connectionString, int Id)
        {
            string query = $"SELECT * FROM Testing WHERE Id = {Id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string gender = reader["Gender"].ToString();
                            string face = reader["Face"].ToString();
                            string hairstyle = reader["Hair_Style"].ToString();
                            string haircolor = reader["Hair_Color"].ToString();
                            string eyetype = reader["Eye_Type"].ToString();
                            string skincolor = reader["Skin_Color"].ToString();
                            string body = reader["Body"].ToString();
                            string undergarment = reader["Undergarment"].ToString();
                            string clothes = reader["Clothes"].ToString();
                            string cosmetics = reader["Cosmetics"].ToString();
                            string tattoo = reader["Tattoo"].ToString();
                            string piercing = reader["Piercing"].ToString();
                            string prosthetics = reader["Prosthetics"].ToString();
                            string scars = reader["Scars"].ToString();
                            string Accessories = reader["Accessories"].ToString();
                            string voice = reader["Voice"].ToString();
                            string job = reader["job"].ToString();
                            string weapon = reader["Weapon"].ToString();
                            string vigor = reader["Vigor"].ToString();
                            string endurance = reader["Endurance"].ToString();
                            string agility = reader["Agility"].ToString();
                            string name = reader["Name"].ToString();
                            string storymode = reader["Story_Mode"].ToString();

                            Console.WriteLine($"\nSelected Character Details:");
                            Console.WriteLine("==========================");
                            Console.WriteLine($"\nGender: {gender} \nFace: {face} \nHair Style: {hairstyle} \nHair Color: {haircolor} \nEye: {eyetype} \nSkin Color: {skincolor} \nBody Color: {body} \nUndergarment: {undergarment} \nClothes: {clothes} \nCosmetics: {cosmetics} \nTattoo: {tattoo} \nPiercing: {piercing} \nProsthetics: {prosthetics} \nScars: {scars} \nAccessories: {Accessories} \nVoice: {voice} \njob: {job} \nWeapon: {weapon} \nVigor: {vigor} \nEndurance: {endurance} \nAgility: {agility} \nName: {name} \nStory Mode {storymode}");
                            Console.WriteLine("Do you want to delete this character? (Y/N): ");
                            char deleteChoice = Console.ReadKey().KeyChar;

                            if (deleteChoice == 'Y' || deleteChoice == 'y')
                            {
                                DeleteCharacter(connectionString, Id);
                                Console.WriteLine($"\nCharacter with ID {Id} deleted.");
                            }
                            else
                            {
                                Console.WriteLine($"\nCharacter with ID {Id} not deleted.");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\nNo character found with ID {Id}.");
                        }
                    }
                }
            }
        }
        private void DeleteCharacter(string connectionString, int Id)
        {
            string deleteQuery = $"DELETE FROM Testing WHERE Id = {Id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }
    public class voiceLevel
    {
        public virtual string DefaultSound() //a virtual method that can be override
        {
            return "Haiya!";
        }
    }
    public class softVoice : voiceLevel //implementing the class voice level
    {
        public override string DefaultSound() // overides the method DefaultSound()
        {
            return "ha-ho-say";
        }
    }
    public class mediumVoice : voiceLevel //implementing the class voice level
    {
        public override string DefaultSound() // overides the method DefaultSound()
        {
            return "Say-Ho-Rah!";
        }
    }
    public class deepVoice : voiceLevel //implementing the class voice level
    {
        public override string DefaultSound() // overides the method DefaultSound()
        {
            return "HO-HEY-ZEN!";
        }
    }
    public class loudVoice : voiceLevel //implementing the class voice level
    {
        public override string DefaultSound() // overides the method DefaultSound()
        {
            return "HAIYA-SORA-RAAAAH!";
        }
    }
    public class SetVoice
    {
        static voiceLevel[] voiceLevels = { new softVoice(), new mediumVoice(), new deepVoice(), new loudVoice() };
        public string voiceChoice { get; set; } //used encap so it can be accessed by the class categories and used by method PrintOutput
        public string voiceSound { get; set; } //used encap so it can be accessed by the class categories and used by method PrintOutput
        public void setVoice()
        {
            string[] Voice = { "Soft", "Medium", "Deep", "Loud" };
            bool validChoice = false;
            int choice = 0;

            Console.WriteLine("\nChoose your Voice:");

            while (!validChoice)
            {
                for (int i = 0; i < Voice.Length; i++) //prints the choices for the user to pick
                {
                    Console.WriteLine($"{i + 1}. {Voice[i]}");
                }

                Console.Write("Enter the number corresponding to your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= Voice.Length)
                    {
                        voiceLevel selectedVoice = voiceLevels[choice - 1];
                        voiceChoice = Voice[choice - 1];
                        voiceSound = selectedVoice.DefaultSound();
                        Console.WriteLine($"Voice: {voiceChoice}, Sound: {voiceSound}");
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Enter a valid number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. The number is too large.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        private Categories categories;

    }
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\XTOFF\ONEDRIVE\DESKTOP\TPCOMPROG\TPCOMPROG\DATABASE1.MDF;Integrated Security=True";
            try
            {
                SetVoice setVoice = new SetVoice();
                Categories c = new Categories(setVoice);

                Console.Write("Do you want to show Existing Characters[Y] or Create a new Character[Type any key]: ");
                char userDes = Console.ReadKey().KeyChar;

                if (userDes == 'Y' || userDes == 'y')
                {
                    /// Display existing characters from the database
                    c.DisplayExistingCharacters(connectionString);

                    Console.Write("Enter the ID of the character you want to select (or enter any key to cancel): ");
                    if (int.TryParse(Console.ReadLine(), out int selectedCharacterId) && selectedCharacterId != 0)
                    {
                        // Fetch and display the details of the selected character
                        c.DisplaySelectedCharacter(connectionString, selectedCharacterId);
                    }
                    else
                    {
                        Console.WriteLine("Selection canceled.");
                    }
                }
                else
                {
                    SetVoice s = new SetVoice();
                        c.setGender();
                        c.setFace();
                        c.setHair();
                        c.setEye();
                        c.setBody();
                        c.setClothes();
                        c.setOthers();
                        s.setVoice();
                        c.setJob();
                        c.setStats();
                        c.setName();
                    while (c.IsNameTaken())
                    {
                        Console.WriteLine("Name Is already taken. Create another name");
                        c.setName();
                    }
 
                        c.setMode();
                        c.PrintOutput(s); // passed the functions of setVoice
                        c.InsertIntoDatabase(s);
                }
                if (!TableExists("Testing", connectionString))
                {
                    string createTableQuery = @"
                USE [C:\USERS\XTOFF\ONEDRIVE\DESKTOP\TPCOMPROG\TPCOMPROG\DATABASE1.MDF];
                CREATE TABLE DATA (
                    Character_Id INT PRIMARY KEY IDENTITY(1,1),
                    Gender NVARCHAR(MAX),
                    
                );
            ";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }

                Categories c2 = new Categories(setVoice);
                SetVoice m = new SetVoice();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        static bool TableExists(string Testing, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{Testing}'", connection))
                {
                    int tableCount = (int)command.ExecuteScalar();
                    return tableCount > 0;
                }
            }
        }
    }
}
