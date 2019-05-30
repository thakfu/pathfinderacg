using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pathfinder3
{
    public class character
    {
        private string mName;
        private string mSet;
        private string mGender;
        private string mRace;
        private string mJob;
        private int mWeapon;
        private int mSpell;
        private int mArmor;
        private int mAlly;
        private int mItem;
        private int mBlessing;
        private string mFave;
        private int mStr;
        private int mDex;
        private int mCon;
        private int mInt;
        private int mWis;
        private int mCha;
        private int mHand;
        private string mSkill1;
        private string mSkill2;
        private string mSkill3;
        private string mSkill4;
        private string mSkill5;
        private int mSkA1;
        private int mSkA2;
        private int mSkA3;
        private int mSkA4;
        private int mSkA5;
        private string mSkL1;
        private string mSkL2;
        private string mSkL3;
        private string mSkL4;
        private string mSkL5;

        public character(string Name, string Set, string Gender, string Race, string Job, 
            int Weapon, int Spell, int Armor, int Item, int Ally, int Blessing, string Fave, 
            int Str, int Dex, int Con, int Int, int Wis, int Cha, int Hand,
            string Skill1, string Skill2, string Skill3, string Skill4, string Skill5,
            int SkA1, int SkA2, int SkA3, int SkA4, int SkA5, 
            string SkL1, string SkL2, string SkL3, string SkL4, string SkL5)
        {
            mName = Name;
            switch (Set)
            {
                case "WOR":
                    {
                        mSet = "Wrath of the Righteous";
                        break;
                    }
                case "SAS":
                    {
                        mSet = "Skull and Shackles";
                        break;
                    }
                case "ROR":
                    {
                        mSet = "Rise of the Runelords";
                        break;
                    }
                case "SORCD":
                    {
                        mSet = "Sorcerer Class Deck";
                        break;
                    }
                case "ROGCD":
                    {
                        mSet = "Rogue Class Deck";
                        break;
                    }
                case "CUST":
                    {
                        mSet = "Custom Creations";
                        break;
                    }
            }
            
            switch (Gender)
            {
                case "M":
                    {
                        mGender = "Male";
                        break;
                    }
                case "F":
                    {
                        mGender = "Female";
                        break;
                    }
            }
            mRace = Race;
            mJob = Job;
            mWeapon = Weapon;
            mSpell = Spell;
            mArmor = Armor;
            mItem = Item;
            mAlly = Ally;
            mBlessing = Blessing;

            switch (Fave)
            {
                case "W":
                    {
                        mFave = "Weapon";
                        break;
                    }
                case "S":
                    {
                        mFave = "Spell";
                        break;
                    }
                case "Ar":
                    {
                        mFave = "Armor";
                        break;
                    }
                case "I":
                    {
                        mFave = "Item";
                        break;
                    }
                case "Al":
                    {
                        mFave = "Ally";
                        break;
                    }
                case "B":
                    {
                        mFave = "Blessing";
                        break;
                    }
                case "WS":
                    {
                        mFave = "Weapon and Spell";
                        break;
                    }
                case "N":
                    {
                        mFave = "None";
                        break;
                    }
            }

            mStr = Str;
            mDex = Dex;
            mCon = Con;
            mInt = Int;
            mWis = Wis;
            mCha = Cha;
            mHand = Hand;
            mSkill1 = Skill1;
            mSkill2 = Skill2;
            mSkill3 = Skill3;
            mSkill4 = Skill4;
            mSkill5 = Skill5;
            mSkA1 = SkA1;
            mSkA2 = SkA2;
            mSkA3 = SkA3;
            mSkA4 = SkA4;
            mSkA5 = SkA5;
            
            switch (SkL1)
            {
                case "S":
                    {
                        mSkL1 = "Str";
                        break;
                    }
                case "D":
                    {
                        mSkL1 = "Dex";
                        break;
                    }
                case "Co":
                    {
                        mSkL1 = "Con";
                        break;
                    }
                case "I":
                    {
                        mSkL1 = "Int";
                        break;
                    }
                case "W":
                    {
                        mSkL1 = "Wis";
                        break;
                    }
                case "Ch":
                    {
                        mSkL1 = "Cha";
                        break;
                    }
            }
            switch (SkL2)
            {
                case "S":
                    {
                        mSkL2 = "Str";
                        break;
                    }
                case "D":
                    {
                        mSkL2 = "Dex";
                        break;
                    }
                case "Co":
                    {
                        mSkL2 = "Con";
                        break;
                    }
                case "I":
                    {
                        mSkL2 = "Int";
                        break;
                    }
                case "W":
                    {
                        mSkL2 = "Wis";
                        break;
                    }
                case "Ch":
                    {
                        mSkL2 = "Cha";
                        break;
                    }
            }

            switch (SkL3)
            {
                case "S":
                    {
                        mSkL3 = "Str";
                        break;
                    }
                case "D":
                    {
                        mSkL3 = "Dex";
                        break;
                    }
                case "Co":
                    {
                        mSkL3 = "Con";
                        break;
                    }
                case "I":
                    {
                        mSkL3 = "Int";
                        break;
                    }
                case "W":
                    {
                        mSkL3 = "Wis";
                        break;
                    }
                case "Ch":
                    {
                        mSkL3 = "Cha";
                        break;
                    }
            }

            switch (SkL4)
            {
                case "S":
                    {
                        mSkL4 = "Str";
                        break;
                    }
                case "D":
                    {
                        mSkL4 = "Dex";
                        break;
                    }
                case "Co":
                    {
                        mSkL4 = "Con";
                        break;
                    }
                case "I":
                    {
                        mSkL4 = "Int";
                        break;
                    }
                case "W":
                    {
                        mSkL4 = "Wis";
                        break;
                    }
                case "Ch":
                    {
                        mSkL4 = "Cha";
                        break;
                    }
            }

            switch (SkL5)
            {
                case "S":
                    {
                        mSkL5 = "Str";
                        break;
                    }
                case "D":
                    {
                        mSkL5 = "Dex";
                        break;
                    }
                case "Co":
                    {
                        mSkL5 = "Con";
                        break;
                    }
                case "I":
                    {
                        mSkL5 = "Int";
                        break;
                    }
                case "W":
                    {
                        mSkL5 = "Wis";
                        break;
                    }
                case "Ch":
                    {
                        mSkL5 = "Cha";
                        break;
                    }
            }

        }

        public override string ToString()
        {

            return this.Name;
        }

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public string Set
        {
            get
            {
                return mSet;
            }

            set
            {
                mSet = value;
            }
        }

        public string Gender
        {
            get
            {
                return mGender;
            }

            set
            {
                mGender = value;
            }
        }

        public string Race
        {
            get
            {
                return mRace;
            }

            set
            {
                mRace = value;
            }
        }

        public string Job
        {
            get
            {
                return mJob;
            }

            set
            {
                mJob = value;
            }
        }

        public int Weapon
        {
            get
            {
                return mWeapon;
            }

            set
            {
                mWeapon = value;
            }
        }

        public int Spell
        {
            get
            {
                return mSpell;
            }

            set
            {
                mSpell = value;
            }
        }

        public int Armor
        {
            get
            {
                return mArmor;
            }

            set
            {
                mArmor = value;
            }
        }

        public int Ally
        {
            get
            {
                return mAlly;
            }

            set
            {
                mAlly = value;
            }
        }

        public int Item
        {
            get
            {
                return mItem;
            }

            set
            {
                mItem = value;
            }
        }

        public int Blessing
        {
            get
            {
                return mBlessing;
            }

            set
            {
                mBlessing = value;
            }
        }

        public string Fave
        {
            get
            {
                return mFave;
            }

            set
            {
                mFave = value;
            }
        }

        public int Str
        {
            get
            {
                return mStr;
            }

            set
            {
                mStr = value;
            }
        }

        public int Dex
        {
            get
            {
                return mDex;
            }

            set
            {
                mDex = value;
            }
        }

        public int Con
        {
            get
            {
                return mCon;
            }

            set
            {
                mCon = value;
            }
        }

        public int Int
        {
            get
            {
                return mInt;
            }

            set
            {
                mInt = value;
            }
        }

        public int Wis
        {
            get
            {
                return mWis;
            }

            set
            {
                mWis = value;
            }
        }

        public int Cha
        {
            get
            {
                return mCha;
            }

            set
            {
                mCha = value;
            }
        }

        public int Hand
        {
            get
            {
                return mHand;
            }

            set
            {
                mHand = value;
            }
        }

        public string Skill1
        {
            get
            {
                return mSkill1;
            }

            set
            {
                mSkill1 = value;
            }
        }

        public string Skill2
        {
            get
            {
                return mSkill2;
            }

            set
            {
                mSkill2 = value;
            }
        }

        public string Skill3
        {
            get
            {
                return mSkill3;
            }

            set
            {
                mSkill3 = value;
            }
        }

        public string Skill4
        {
            get
            {
                return mSkill4;
            }

            set
            {
                mSkill4 = value;
            }
        }

        public string Skill5
        {
            get
            {
                return mSkill5;
            }

            set
            {
                mSkill5 = value;
            }
        }

        public int SkA1
        {
            get
            {
                return mSkA1;
            }

            set
            {
                mSkA1 = value;
            }
        }

        public int SkA2
        {
            get
            {
                return mSkA2;
            }

            set
            {
                mSkA2 = value;
            }
        }

        public int SkA3
        {
            get
            {
                return mSkA3;
            }

            set
            {
                mSkA3 = value;
            }
        }

        public int SkA4
        {
            get
            {
                return mSkA4;
            }

            set
            {
                mSkA4 = value;
            }
        }

        public int SkA5
        {
            get
            {
                return mSkA5;
            }

            set
            {
                mSkA5 = value;
            }
        }

        public string SkL1
        {
            get
            {
                return mSkL1;
            }

            set
            {
                mSkL1 = value;
            }
        }

        public string SkL2
        {
            get
            {
                return mSkL2;
            }

            set
            {
                mSkL2 = value;
            }
        }

        public string SkL3
        {
            get
            {
                return mSkL3;
            }

            set
            {
                mSkL3 = value;
            }
        }

        public string SkL4
        {
            get
            {
                return mSkL4;
            }

            set
            {
                mSkL4 = value;
            }
        }

        public string SkL5
        {
            get
            {
                return mSkL5;
            }

            set
            {
                mSkL5 = value;
            }
        }
    }
}
