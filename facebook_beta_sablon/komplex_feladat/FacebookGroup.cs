using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komplex_feladat
{
    class FacebookGroup : IFacebookGroup
    {
        // FIELDS AND PROPERTIES

        User[] members; // ők a tagok
        User[] admins; // ők is tagok de admin joggal
        User owner; // ő pedig a csoport létrehozója/tulaja
        public string Title     { get; set; }
        public int StartYear    { get; set; }
        int memberIndex;
        int adminIndex;


        // ********** delegált + esemény!...

        private delegate void GroupMembersAreFullEventHandler(object src, FacebookGroupEventArgs args);

        public event GroupMembersAreFullEventHandler MembersAreFull;

        public User[] Admins
        {
            get { return admins; }
        }
        public User[] Members
        {
            get { return members; }
        }
        public User Owner
        {
            get { return this.owner; }
        }


        // CONSTRUCTOR

        public FacebookGroup(User owner, string title)
        {
            this.Title = title;
            members = new User[5];
            admins = new User[3];
            
            this.owner = owner;
            admins[adminIndex++] = owner;
            
            memberIndex = 0;
        }

        
        // METHODS

        public void AddMember(User whoIsAdding, User whoWillBeAdded)
        {
            // ha admin (tömbben van) akkor adhat hozzá
            // default esetben, aki létrehozza a csoportot az alapból admin lesz
            // lsd. konstruktor


           
        }

        public void MakeMemberToAdmin(User whoIsMaking, User whoWillBeMade)
        {
            
        }

        private bool IsAmongAdmins(User user)
        {
            
        }

        public override string ToString()
        {
            

        protected virtual void OnMembersAreFull(FacebookGroup group)
        {
                if(Members)
        }
    }
}
