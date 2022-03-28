> Гладиаторские бои

        Создать 5 бойцов, пользователь выбирает 2 бойцов и они сражаются друг с другом до смерти. У каждого бойца
        могут быть свои статы.Каждый игрок должен иметь особую способность для атаки, которая свойственна
        только его классу!

* **abstract class Fighter** - поля WayInformation, WayPassengers, метод BuyTiket

* **Superman : Fighter** - Mana, метод UniqueAbility() - выжигает глазами

* **Healer : Fighter** - Mana, метод UniqueAbility() - увеличивает здоровье

* **Warrior : Fighter** - _agr запустил ли агр, метод UniqueAbility() - увеличивает броню

* **Necromant : Fighter** - Mana, SucksHealth, метод UniqueAbility() - высасывает здоровье

* **Mag : Fighter** - Mana, метод UniqueAbility() - запускает Огненный шар

* **class Program** - Генерируем бойцов в fighters, выбираем fightersLeft и fightersRight случайных бойцов из списка.
Бой между бойцами и объявления победителей и проигравших.



