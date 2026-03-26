using System;
using System.Collections.Generic;

namespace RandomDungeon
{
    public class Program
    {
        // Argumentos
        // args[0]: Seed para Simulação de Batalhas
        // args[1]: Seed para Criação de Inimigos (Opcional)
        private static void Main(string[] args)
        {
            Arena arena = new Arena(new List<Enemy>());
            Random random = new Random(int.Parse(args[0]));

            if (args.Length == 2)
            {
                // Gera 10 Inimigos Aleatórios
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 1));
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 2));
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 3));
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 4));
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 5));
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 6));
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 7));
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 8));
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 9));
                arena.AddEnemy(Enemy.GenerateRandomEnemy(int.Parse(args[0]) + 10));
            } else {
                // Gera 4 Inimigos Predefinidos
                arena.AddEnemy(new Enemy("Goblin", 100, 10));
                arena.AddEnemy(new Enemy("Orc", 120, 15));
                arena.AddEnemy(new Enemy("Troll", 150, 20));
                arena.AddEnemy(new Enemy("Skeleton", 80, 8));
            }

            // Mostra a Lista de Inimigos Atualmente na Arena
            // CÓDIGO AQUI
            
            // Repetir Batalha (Enquanto Existe Mais do que 1 Inimigo)
            while (// CÓDIGO AQUI)
            {
                // Obter a Lista Atual de Inimigos
                List<Enemy> enemies = arena.GetEnemies();

                // Selecionar Aleatoriamente um Atacante
                int attackerIndex = random.Next(enemies.Count);

                // Selecionar Aleatoriamente um Defensor
                // Garantindo que Não Seja o Mesmo que o Atacante
                int defenderIndex;
                // CÓDIGO AQUI
                
                // Obter os Objetos Atacante e Defensor
                Enemy attacker = enemies[attackerIndex];
                Enemy defender = enemies[defenderIndex];

                arena.Battle(attacker, defender);

            }

            Console.WriteLine($"{arena.GetEnemies()[0].GetName()} Wins!");
        }
    }
}
