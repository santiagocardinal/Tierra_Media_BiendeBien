namespace Program;

public class Elf
{
    private string name;
    private List<Item> element;
    private int amountLife;
    public static int initialLife { get; set; } = 50;


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Item> Element
    {
        get { return element; }
        set { element = value; }
    }

    public int AmountLife
    {
        get { return amountLife; }
        set { amountLife = value; }
    }

    //public int VidaInicial{ get {return vidaInicial;} set { vidaInicial = value; } }

    public Elf(string name, List<Item> elements)
    {
        this.Name = name;
        this.Element = elements ?? new List<Item>();
        this.AmountLife = initialLife;
    }


    public void AddItem(Item element)
    {
        this.Element.Add(element);
    }

    public void RemoveItem(Item element)
    {
        this.Element.Remove(element);
    }

    public void ExchangeItem(Item e1, Item e2)
    {
        int index = this.Element.IndexOf(e1);
        if (index != -1)
        {
            this.Element[index] = e2;
        }
    }
    
    public void GetDefense(Element defense)
    {
        this.AmountLife += defense.Defense;
    }

    public void Heal()
    {
        this.AmountLife = this.InitialLife;
    }
    

    public void ElfDwarf(Dwarf dwarf)
    {
        foreach (var item in dwarf.Element)
        {
            this.AmountLife -= item.DamageValue;
        }
    }
    public void ElfWizard(Wizard wizard)
    {
        foreach (var item in wizard.Element)
        {
            this.AmountLife -= item.DamageValue;
        }
    }
    public void ElfElf(Elf elf)
    {
        foreach (var item in elf.Element)
        {
            this.AmountLife -= item.DamageValue;
        }
    }
}
