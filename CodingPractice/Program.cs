using System;
using System.Reflection.Metadata.Ecma335;

// 1-1
{
    Parent parent = new Parent();
    Child child = new Child();
    parent.Work();
    child.Work();
    Console.WriteLine();
}

// 1-2
{
    Animal animal2 = new Cat();
    Animal animal1 = new Animal();
    animal1.Eat();
    animal2.Eat();
    Console.WriteLine();
}

// 2
{
    Child child = new Child();
    Parent parent = child;
    child.Say();
    child.Run();
    child.Walk();
    Console.WriteLine();
    parent.Say();
    parent.Run();
    parent.Walk();
    Console.WriteLine();
}

// 3-1
{
    Calculator calculator = new Calculator();
    Console.WriteLine(calculator.Add(1, 2));
    Console.WriteLine(calculator.Add(1.0, 3.0));
    Console.WriteLine(calculator.Add(1, 2, 3));
    Console.WriteLine();
}

// 3-2
{
    Animal animal = new Animal();
    Animal dog = new Dog();
    Animal cat = new Cat();
    animal.Speak();
    dog.Speak();
    cat.Speak();
    Console.WriteLine();
}

// 4-1
{
    Child child = new Child();
    child.Greet();
    Console.WriteLine();
}

// 4-2
{
    Parent parent = new Parent();
    Parent child = new Child();
    Parent grandChild = new GrandChild();

    parent.Work();
    child.Work();
    grandChild.Work();
    Console.WriteLine();
}

// 5
{
    Parent parent = new Parent();
    Parent child = new Child();
    GrandChild grand = new GrandChild();
    parent.Work();
    child.Work();
    grand.Work();
    grand.Play();

    Console.WriteLine();
}

// 6-1
{
    Person person = new Person();
    Console.WriteLine(person);
    Console.WriteLine(person.ToString());
    Console.WriteLine();
}

// 6-2
{
    Person person = new Person { Name = "박용준" };
    Console.WriteLine(person);
    Console.WriteLine();
}

// 6-3
{
    Character warrior = new Character("용사", 10, 100);
    Character mage = new Character("마법사", 8, 70);
    Console.WriteLine(warrior);
    Console.WriteLine(mage);
    Console.WriteLine();

}

// 7-1
{
    Character warrior = new Warrior("전사", 50);
    Character mage = new Mage("마법사", 30);
    Character archer = new Archer("궁수", 40);

    Console.WriteLine(warrior);
    Console.WriteLine(mage);
    Console.WriteLine(archer);
    Console.WriteLine();
    warrior.Attack();
    mage.Attack();
    archer.Attack();
    Console.WriteLine();
}

// 7-2
{
    Character[] characters = new Character[3];
    characters[0] = new Warrior("전사", 50);
    characters[1] = new Mage("마법사", 30);
    characters[2] = new Archer("궁수", 40);

    Console.WriteLine("=== 파티 공격 ===");
    foreach(Character character in characters)
    {
        character.Attack();
    }
}

// --- class 정의 ---

// 1-1
class Parent
{
    public void Say()
    {
        Console.WriteLine("부모_안녕하세요.");
    }
    public void Run()
    {
        Console.WriteLine("부모_달리다");
    }
    public virtual void Walk()
    {
        Console.WriteLine("부모_걷다.");
    }
    public virtual void Work()
    {
        Console.WriteLine("프로그래머");
    }
    public virtual void Greet()
    {
        Console.WriteLine("안녕하세요");
    }

}

class Child : Parent
{
    public new void Say()
    {
        Console.WriteLine("자식_안녕하세요.");
    }
    public new void Run()
    {
        Console.WriteLine("자식_달리다");
    }
    public override void Walk()
    {
        Console.WriteLine("자식_걷다.");
    }
    public sealed override void Work()
    {
        //base.Work();
        //Console.WriteLine("프로게이머");
        Console.WriteLine("프로그래머");   
    }
    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("반갑습니다.");
    }
}

class GrandChild : Child
{
    /*public virtual void Work()
    {
        Console.WriteLine("프로게이머");
    }
    */
    public void Play()
    {
        Console.WriteLine("프로게이머");
    }
}

// 1-2
class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal Eat");
    }
    public virtual void Speak()
    {
        Console.WriteLine("동물이 소리를 낸다");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("멍멍");
    }
}
class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cat Eat");
    }
    public override void Speak()
    {
        Console.WriteLine("야옹!");
    }
}

// 3-1
class Calculator
{
    public int Add(int x, int y) => x + y;
    public double Add(double x, double y) => x + y;
    public int Add(int x, int y, int z) => x + y + z;
}

// 6-1 && 6-2
class Person
{
    public string Name { get; set; } = "Petty";

    public override string ToString()
    {
        return $"[Person 클래스: {Name}]";
    }

}

// 6-3
class Character
{
    public string Name;
    public int Level;
    public int Health;
    public int AttackPower;

    public Character(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;
    }

    public Character(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public virtual void Attack() { }

    //public override string ToString() { return $"[{Name}] Lv.{Level} HP: {Health}"; }
    public override string ToString() { return $"[{Name}] 공격력: {AttackPower}"; }

}
class Warrior : Character
{
    public Warrior(string name, int attackPower) : base(name, attackPower) { }
    public override void Attack() { Console.WriteLine($"{Name}이(가) 칼로 베어냅니다 ! 데미지: {AttackPower}"); }

}
class Mage : Character
{
    public Mage(string name, int attackPower) : base(name, attackPower) { }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 파이어볼을 시전합니다 ! 데미지: {AttackPower * 2}");
    }

}
class Archer : Character
{
    public Archer(string name, int attackPower) : base(name, attackPower) { }
    public override void Attack() { Console.WriteLine($"{Name}이(가) 화살을 쏩니다 ! 데미지: {AttackPower}"); }
}