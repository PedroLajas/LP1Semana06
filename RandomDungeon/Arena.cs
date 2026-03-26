using System;
using System.Collections.Generic;

namespace RandomDungeon
{
    public class Arena
    {
        private List<Enemy> enemies;

        public Arena(List<Enemy> enemies)
        {
            this.enemies = enemies;
        }

        public List<Enemy> GetEnemies()
        {
            return enemies;
        }

        public void SetEnemies(List<Enemy> value)
        {
            enemies = value;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        // Método Para Mostrar Todos os Inimigos Atuais
        // Exemplo: "Arena: Troll, Skeleton, Ogre"
        public void ShowEnemies()
        {
            Console.WriteLine("Arena: ");
            for (int i = 0; i < enemies.Count; i++)
            {
                if (i > 0)
                    Console.WriteLine(", ");
                Console.WriteLine(enemies[i].GetName());
            }
            Console.WriteLine();
        }
        
        // Simula uma Batalha Entre Dois Inimigos
        public void Battle(Enemy attacker, Enemy defender)
        {
            int newHealth = defender.GetHealth() - attacker.GetAttack();

            if (newHealth < 0) newHealth = 0;
            defender.SetHealth(newHealth);

            if (defender.GetHealth() == 0)
            {
                RemoveEnemy(defender);
            }
        }
    }
}