using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkFinal_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList team = new LinkedList();
            team.AddLast(new Character("Warrior", 100, 50));
            team.AddLast(new Character("Mage", 80, 30));
            team.AddLast(new Character("Archer", 90, 40));
            team.AddLast(new Character("Healer", 50, 70));

            List<Character> availableCharacters = new List<Character>
        {
            new Character("Rogue", 95, 45),
            new Character("Paladin", 110, 60),
            new Character("Necromancer", 70, 40)
        };

            while (true)
            {
                Console.WriteLine("\n=== 隊伍管理選單 ===");
                Console.WriteLine("1. 顯示角色隊伍");
                Console.WriteLine("2. 替換角色");
                Console.WriteLine("3. 新增成員");
                Console.WriteLine("4. 排序隊伍");
                Console.WriteLine("5. 離開程式");
                Console.Write("請選擇一個選項：");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n=== 隊伍成員 ===");
                        team.DisplayTeam();
                        break;

                    case "2":
                        ReplaceCharacter(team, availableCharacters);
                        break;

                    case "3":
                        AddCharacter(team, availableCharacters);
                        break;

                    case "4":
                        SortTeam(team);
                        break;

                    case "5":
                        Console.WriteLine("退出程式！");
                        return;

                    default:
                        Console.WriteLine("無效選項，請重新選擇！");
                        break;
                }
            }


        }

        //替換角色程式
        static void ReplaceCharacter(LinkedList team, List<Character> availableCharacters)
        {
            Console.WriteLine("\n=== 替換角色 ===");
            Console.WriteLine("目前隊伍：");
            team.DisplayTeam();

            Console.Write("請選擇要替換的隊伍位置：");
            int position;
            if (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > team.Count())
            {
                Console.WriteLine("無效的位置！");
                return;
            }

            Console.WriteLine("\n後台角色清單：");
            for (int i = 0; i < availableCharacters.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {availableCharacters[i]}");
            }

            Console.Write("請選擇要替換的角色編號：");
            int selection;
            if (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > availableCharacters.Count)
            {
                Console.WriteLine("無效的角色編號！");
                return;
            }

            Character selectedCharacter = availableCharacters[selection - 1];
            team.Replace(position - 1, selectedCharacter);

            Console.WriteLine("\n角色替換完成！");
            team.DisplayTeam();
        }

        static void AddCharacter(LinkedList team, List<Character> availableCharacters)
        {
            Console.WriteLine("\n後台角色清單：");
            for (int i = 0; i < availableCharacters.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {availableCharacters[i]}");
            }

            Console.Write("請輸入要新增到隊伍的角色編號：");
            int selection;
            if (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > availableCharacters.Count)
            {
                Console.WriteLine("無效的角色編號！");
                return;
            }

            Character selectedCharacter = availableCharacters[selection - 1];
            team.AddLast(selectedCharacter);

            Console.WriteLine($"\n角色 [{selectedCharacter.Name}] 已加入隊伍的最後一個位置！");
            Console.WriteLine("目前隊伍為：");
            team.DisplayTeam();
        }

        static void SortTeam(LinkedList team)
        {
            team.Sort();
            Console.WriteLine("\n隊伍已按照攻擊力排序！");
            team.DisplayTeam();
        }
    }
}
