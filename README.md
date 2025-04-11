```mermaid
classDiagram
    class Character {
        - Weapon[] weapons
        + string Name
        + void Fight()
    }

    class Weapon {
        - float power
    }

    class Gun {
        + int Ammo
        + void FireGun()
    }

    class Sword {
        + float BladeLength
        + void AttackWithSword()
    }

    class Player {
        + Player(string name)
    }

    class Enemy {
        + Enemy(string name)
    }

    class Program {
        - static void Main()
    }

    Character <|-- Player
    Character <|-- Enemy
    Weapon <|-- Gun
    Weapon <|-- Sword
    Program --> Character : usa
    Character --> Weapon : possui
