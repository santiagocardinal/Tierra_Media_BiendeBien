namespace Program;

public class Wizard
{
    private List<Item> lstElement;
    private int amountLife;
    public static int initialLife { get; set; } = 50;
    //private SpellBook spell;

    public List<Item> LstElement
    {
        get { return lstElement; }
        set { LstElement = value; }

    }

    public int AmountLife
    {
        get { return AmountLife; }
        set { AmountLife = value; }
    }

    /*public int InitialLife
    {
        get { return InitialLife; }
        set { InitialLife = value; }
    }
*/
    /*public SpellBook Spell
    {
        get { return spell; }
        set { spell = value; }
    }
    
    public Wizard(List<Item> element, spellBook spell)
    {
        this.LstElement = element;
        this.AmountLife = initialLife;
       // this.InitialLife = initialLife;
        this.Spell = spell;
    }
*/
    public void AddItem(Item element)
    {
        this.LstElement.Add(element);
        this.AmountLife += element.DefenseValue;
    }

    public void RemoveItem(Item element)
    {
        this.LstElement.Remove(element);
        this.AmountLife -= element.DefenseValue;
    }

    public void ExchangeItem(Item e1, Item e2)
    {
        int indice = 0;
        foreach (var i in this.LstElement)
        {
            if (i == e1)
            {
                indice = LstElement.IndexOf(i);
            }
        }

        this.LstElement[indice] = e2;
    }

   /* public void GetAttack(Item element)
    {
        this.AmountLife-=attack.Damage;
    }

    public void GetDefense(LstElement defense)
    {
        this.AmountLife+=defense.Defense;
    }
*/
    public void Heal()
    {
        this.AmountLife = initialLife;
    }

  /*  public void AddSpell(SpellBook book)
    {
        
    }
*/
    public void WizardElf(Elf elf)
    {
        foreach (var item in elf.Element)
        {
            this.AmountLife -= item.AttackValue;
        }
    }

    public void WizardDwarf(Dwarf dwarf)
    {
        foreach (var item in dwarf.Element)
        {
            this.AmountLife -= item.AttackValue;
        }
    }

    public void WizardWizard(Wizard wizard)
    {
        foreach (var item in wizard.LstElement)
        {
            this.AmountLife -= item.AttackValue;
        }
    }
}