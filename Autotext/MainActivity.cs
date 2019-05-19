using System;
using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.Icu.Util;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.Content;
using Android.Support.V7.App;
using Android.Telephony;
using Android.Views;
using Android.Widget;
using Autotext;
using Android.Support.V4.App;
using TaskStackBuilder = Android.Support.V4.App.TaskStackBuilder;


namespace Autotext
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public String[] girlName = { "Emma", "Olivia", "Ava", "Isabella", "Sophia", "Charlotte", "Mia", "Amelia", "Harper", "Evelyn", "Abigail", "Emily", "Elizabeth", "Mila", "Ella", "Avery", "Sofia", "Camila", "Aria", "Scarlett", "Victoria", "Madison", "Luna", "Grace", "Chloe", "Penelope", "Layla", "Riley", "Zoey", "Nora", "Lily", "Eleanor", "Hannah", "Lillian", "Addison", "Aubrey", "Ellie", "Stella", "Natalie", "Zoe", "Leah", "Hazel", "Violet", "Aurora", "Savannah", "Audrey", "Brooklyn", "Bella", "Claire", "Skylar", "Lucy", "Paisley", "Everly", "Anna", "Caroline", "Nova", "Genesis", "Emilia", "Kennedy", "Samantha", "Maya", "Willow", "Kinsley", "Naomi", "Aaliyah", "Elena", "Sarah", "Ariana", "Allison", "Gabriella", "Alice", "Madelyn", "Cora", "Ruby", "Eva", "Serenity", "Autumn", "Adeline", "Hailey", "Gianna", "Valentina", "Isla", "Eliana", "Quinn", "Nevaeh", "Ivy", "Sadie", "Piper", "Lydia", "Alexa", "Josephine", "Emery", "Julia", "Delilah", "Arianna", "Vivian", "Kaylee", "Sophie", "Brielle", "Madeline", "Peyton", "Rylee", "Clara", "Hadley", "Melanie", "Mackenzie", "Reagan", "Adalynn", "Liliana", "Aubree", "Jade", "Katherine", "Isabelle", "Natalia", "Raelynn", "Maria", "Athena", "Ximena", "Arya", "Leilani", "Taylor", "Faith", "Rose", "Kylie", "Alexandra", "Mary", "Margaret", "Lyla", "Ashley", "Amaya", "Eliza", "Brianna", "Bailey", "Andrea", "Khloe", "Jasmine", "Melody", "Iris", "Isabel", "Norah", "Annabelle", "Valeria", "Emerson", "Adalyn", "Ryleigh", "Eden", "Emersyn", "Anastasia", "Kayla", "Alyssa", "Juliana", "Charlie", "Esther", "Ariel", "Cecilia", "Valerie", "Alina", "Molly", "Reese", "Aliyah", "Lilly", "Parker", "Finley", "Morgan", "Sydney", "Jordyn", "Eloise", "Trinity", "Daisy", "Kimberly", "Lauren", "Genevieve", "Sara", "Arabella", "Harmony", "Elise", "Remi", "Teagan", "Alexis", "London", "Sloane", "Laila", "Lucia", "Diana", "Juliette", "Sienna", "Elliana", "Londyn", "Ayla", "Callie", "Gracie", "Josie", "Amara", "Jocelyn", "Daniela", "Everleigh", "Mya", "Rachel", "Summer", "Alana", "Brooke", "Alaina", "Mckenzie", "Catherine", "Amy", "Presley", "Journee", "Rosalie", "Ember", "Brynlee", "Rowan", "Joanna", "Paige", "Rebecca", "Ana", "Sawyer", "Mariah", "Nicole", "Brooklynn", "Payton", "Marley", "Fiona", "Georgia", "Lila", "Harley", "Adelyn", "Alivia", "Noelle", "Gemma", "Vanessa", "Journey", "Makayla", "Angelina", "Adaline", "Catalina", "Alayna", "Julianna", "Leila", "Lola", "Adriana", "June", "Juliet", "Jayla", "River", "Tessa", "Lia", "Dakota", "Delaney", "Selena", "Blakely", "Ada", "Camille", "Zara", "Malia", "Hope", "Samara", "Vera", "Mckenna", "Briella", "Izabella", "Hayden", "Raegan", "Michelle", "Angela", "Ruth", "Freya", "Kamila", "Vivienne", "Aspen", "Olive", "Kendall", "Elaina", "Thea", "Kali", "Destiny", "Amiyah", "Evangeline", "Cali", "Blake", "Elsie", "Juniper", "Alexandria", "Myla", "Ariella", "Kate", "Mariana", "Lilah", "Charlee", "Daleyza", "Nyla", "Jane", "Maggie", "Zuri", "Aniyah", "Lucille", "Leia", "Melissa", "Adelaide", "Amina", "Giselle", "Lena", "Camilla", "Miriam", "Millie", "Brynn", "Gabrielle", "Sage", "Annie", "Logan", "Lilliana", "Haven", "Jessica", "Kaia", "Magnolia", "Amira", "Adelynn", "Makenzie", "Stephanie", "Nina", "Phoebe", "Arielle", "Evie", "Lyric", "Alessandra", "Gabriela", "Paislee", "Raelyn", "Madilyn", "Paris", "Makenna", "Kinley", "Gracelyn", "Talia", "Maeve", "Rylie", "Kiara", "Evelynn", "Brinley", "Jacqueline", "Laura", "Gracelynn", "Lexi", "Ariah", "Fatima", "Jennifer", "Kehlani", "Alani", "Ariyah", "Luciana", "Allie", "Heidi", "Maci", "Phoenix", "Felicity", "Joy", "Kenzie", "Veronica", "Margot", "Addilyn", "Lana", "Cassidy", "Remington", "Saylor", "Ryan", "Keira", "Harlow", "Miranda", "Angel", "Amanda", "Daniella", "Royalty", "Gwendolyn", "Ophelia", "Heaven", "Jordan", "Madeleine", "Esmeralda", "Kira", "Miracle", "Elle", "Amari", "Danielle", "Daphne", "Willa", "Haley", "Gia", "Kaitlyn", "Oakley", "Kailani", "Winter", "Alicia", "Serena", "Nadia", "Aviana", "Demi", "Jada", "Braelynn", "Dylan", "Ainsley", "Alison", "Camryn", "Avianna", "Bianca", "Skyler", "Scarlet", "Maddison", "Nylah", "Sarai", "Regina", "Dahlia", "Nayeli", "Raven", "Helen", "Adrianna", "Averie", "Skye", "Kelsey", "Tatum", "Kensley", "Maliyah", "Erin", "Viviana", "Jenna", "Anaya", "Carolina", "Shelby", "Sabrina", "Mikayla", "Annalise", "Octavia", "Lennon", "Blair", "Carmen", "Yaretzi", "Kennedi", "Mabel", "Zariah", "Kyla", "Christina", "Selah", "Celeste", "Eve", "Mckinley", "Milani", "Frances", "Jimena", "Kylee", "Leighton", "Katie", "Aitana", "Kayleigh", "Sierra", "Kathryn", "Rosemary", "Jolene", "Alondra", "Elisa", "Helena", "Charleigh", "Hallie", "Lainey", "Avah", "Jazlyn", "Kamryn", "Mira", "Cheyenne", "Francesca", "Antonella", "Wren", "Chelsea", "Amber", "Emory", "Lorelei", "Nia", "Abby", "April", "Emelia", "Carter", "Aylin", "Cataleya", "Bethany", "Marlee", "Carly", "Kaylani", "Emely", "Liana", "Madelynn", "Cadence", "Matilda", "Sylvia", "Myra", "Fernanda", "Oaklyn", "Elianna", "Hattie", "Dayana", "Kendra", "Maisie", "Malaysia", "Kara" };
        public String[] boyName = { "Liam", "Noah", "William", "James", "Oliver", "Benjamin", "Elijah", "Lucas", "Mason", "Logan", "Alexander", "Ethan", "Jacob", "Michael", "Daniel", "Henry", "Jackson", "Sebastian", "Aiden", "Matthew", "Samuel", "David", "Joseph", "Carter", "Owen", "Wyatt", "John", "Jack", "Luke", "Jayden", "Dylan", "Grayson", "Levi", "Isaac", "Gabriel", "Julian", "Mateo", "Anthony", "Jaxon", "Lincoln", "Joshua", "Christopher", "Andrew", "Theodore", "Caleb", "Ryan", "Asher", "Nathan", "Thomas", "Leo", "Isaiah", "Charles", "Josiah", "Hudson", "Christian", "Hunter", "Connor", "Eli", "Ezra", "Aaron", "Landon", "Adrian", "Jonathan", "Nolan", "Jeremiah", "Easton", "Elias", "Colton", "Cameron", "Carson", "Robert", "Angel", "Maverick", "Nicholas", "Dominic", "Jaxson", "Greyson", "Adam", "Ian", "Austin", "Santiago", "Jordan", "Cooper", "Brayden", "Roman", "Evan", "Ezekiel", "Xavier", "Jose", "Jace", "Jameson", "Leonardo", "Bryson", "Axel", "Everett", "Parker", "Kayden", "Miles", "Sawyer", "Jason", "Declan", "Weston", "Micah", "Ayden", "Wesley", "Luca", "Vincent", "Damian", "Zachary", "Silas", "Gavin", "Chase", "Kai", "Emmett", "Harrison", "Nathaniel", "Kingston", "Cole", "Tyler", "Bennett", "Bentley", "Ryker", "Tristan", "Brandon", "Kevin", "Luis", "George", "Ashton", "Rowan", "Braxton", "Ryder", "Gael", "Ivan", "Diego", "Maxwell", "Max", "Carlos", "Kaiden", "Juan", "Maddox", "Justin", "Waylon", "Calvin", "Giovanni", "Jonah", "Abel", "Jayce", "Jesus", "Amir", "King", "Beau", "Camden", "Alex", "Jasper", "Malachi", "Brody", "Jude", "Blake", "Emmanuel", "Eric", "Brooks", "Elliot", "Antonio", "Abraham", "Timothy", "Finn", "Rhett", "Elliott", "Edward", "August", "Xander", "Alan", "Dean", "Lorenzo", "Bryce", "Karter", "Victor", "Milo", "Miguel", "Hayden", "Graham", "Grant", "Zion", "Tucker", "Jesse", "Zayden", "Joel", "Richard", "Patrick", "Emiliano", "Avery", "Nicolas", "Brantley", "Dawson", "Myles", "Matteo", "River", "Steven", "Thiago", "Zane", "Matias", "Judah", "Messiah", "Jeremy", "Preston", "Oscar", "Kaleb", "Alejandro", "Marcus", "Mark", "Peter", "Maximus", "Barrett", "Jax", "Andres", "Holden", "Legend", "Charlie", "Knox", "Kaden", "Paxton", "Kyrie", "Kyle", "Griffin", "Josue", "Kenneth", "Beckett", "Enzo", "Adriel", "Arthur", "Felix", "Bryan", "Lukas", "Paul", "Brian", "Colt", "Caden", "Leon", "Archer", "Omar", "Israel", "Aidan", "Theo", "Javier", "Remington", "Jaden", "Bradley", "Emilio", "Colin", "Riley", "Cayden", "Phoenix", "Clayton", "Simon", "Ace", "Nash", "Derek", "Rafael", "Zander", "Brady", "Jorge", "Jake", "Louis", "Damien", "Karson", "Walker", "Maximiliano", "Amari", "Sean", "Chance", "Walter", "Martin", "Finley", "Andre", "Tobias", "Cash", "Corbin", "Arlo", "Iker", "Erick", "Emerson", "Gunner", "Cody", "Stephen", "Francisco", "Killian", "Dallas", "Reid", "Manuel", "Lane", "Atlas", "Rylan", "Jensen", "Ronan", "Beckham", "Daxton", "Anderson", "Kameron", "Raymond", "Orion", "Cristian", "Tanner", "Kyler", "Jett", "Cohen", "Ricardo", "Spencer", "Gideon", "Ali", "Fernando", "Jaiden", "Titus", "Travis", "Bodhi", "Eduardo", "Dante", "Ellis", "Prince", "Kane", "Luka", "Kash", "Hendrix", "Desmond", "Donovan", "Mario", "Atticus", "Cruz", "Garrett", "Hector", "Angelo", "Jeffrey", "Edwin", "Cesar", "Zayn", "Devin", "Conor", "Warren", "Odin", "Jayceon", "Romeo", "Julius", "Jaylen", "Hayes", "Kayson", "Muhammad", "Jaxton", "Joaquin", "Caiden", "Dakota", "Major", "Keegan", "Sergio", "Marshall", "Johnny", "Kade", "Edgar", "Leonel", "Ismael", "Marco", "Tyson", "Wade", "Collin", "Troy", "Nasir", "Conner", "Adonis", "Jared", "Rory", "Andy", "Jase", "Lennox", "Shane", "Malik", "Ari", "Reed", "Seth", "Clark", "Erik", "Lawson", "Trevor", "Gage", "Nico", "Malakai", "Quinn", "Cade", "Johnathan", "Sullivan", "Solomon", "Cyrus", "Fabian", "Pedro", "Frank", "Shawn", "Malcolm", "Khalil", "Nehemiah", "Dalton", "Mathias", "Jay", "Ibrahim", "Peyton", "Winston", "Kason", "Zayne", "Noel", "Princeton", "Matthias", "Gregory", "Sterling", "Dominick", "Elian", "Grady", "Russell", "Finnegan", "Ruben", "Gianni", "Porter", "Kendrick", "Leland", "Pablo", "Allen", "Hugo", "Raiden", "Kolton", "Remy", "Ezequiel", "Damon", "Emanuel", "Zaiden", "Otto", "Bowen", "Marcos", "Abram", "Kasen", "Franklin", "Royce", "Jonas", "Sage", "Philip", "Esteban", "Drake", "Kashton", "Roberto", "Harvey", "Alexis", "Kian", "Jamison", "Maximilian", "Adan", "Milan", "Phillip", "Albert", "Dax", "Mohamed", "Ronin", "Kamden", "Hank", "Memphis", "Oakley", "Augustus", "Drew", "Moises", "Armani", "Rhys", "Benson", "Jayson", "Kyson", "Braylen", "Corey", "Gunnar", "Omari", "Alonzo", "Landen", "Armando", "Derrick", "Dexter", "Enrique", "Bruce", "Nikolai", "Francis", "Rocco", "Kairo", "Royal", "Zachariah", "Arjun", "Deacon", "Skyler", "Eden", "Alijah", "Rowen", "Pierce", "Uriel", "Ronald", "Luciano", "Tate", "Frederick", "Kieran", "Lawrence", "Moses", "Rodrigo" };
        
        public static bool reminderSet = false;

        private static Random rnd = new Random();
        public AlarmManager am;
        static readonly string CHANNEL_ID = "location_notification";
        internal static readonly string COUNT_KEY = "count";
        private void CheckAppPermissions()
        {
            if ((int)Build.VERSION.SdkInt < 23)
            {
                return;
            }
            else
            {
                if (PackageManager.CheckPermission(Manifest.Permission.SendSms, PackageName) != Permission.Granted)
                {
                    string[] permissions = new string[] { Manifest.Permission.SendSms };
                    RequestPermissions(permissions, 0);
                }
            }
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            CheckAppPermissions();
            CreateNotificationChannel();
            Intent alarmIntent = new Intent(this, typeof(AlarmReceiver));
            PendingIntent pending = PendingIntent.GetBroadcast(Application.Context, 0, alarmIntent, PendingIntentFlags.UpdateCurrent);
            am = GetSystemService(AlarmService).JavaCast<AlarmManager>();
          
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            Button send = FindViewById<Button>(Resource.Id.Send);
            send.Click += SendOnClick;
            Button generate = FindViewById<Button>(Resource.Id.Generate);
            generate.Click += GenerateOnClick;
        }
        private void SendOnClick(object sender, EventArgs eventArgs)
        {
            SmsManager _smsManager;
            _smsManager = SmsManager.Default;

            EditText boy = FindViewById<EditText>(Resource.Id.First);
            EditText girl = FindViewById<EditText>(Resource.Id.FirstG);
            EditText boyM = FindViewById<EditText>(Resource.Id.Middle);
            EditText girlM = FindViewById<EditText>(Resource.Id.MiddleG);
            if (boy.Text == "")
            {
                GenerateNames();
            }
            //_smsManager.SendTextMessage("4197969464", null, "message", null, null);
            _smsManager.SendTextMessage("9375704370", null, "Boy Name: " + boy.Text + " " + boyM.Text + "\n" + "Girl Name: " + girl.Text + " " + girlM.Text, null, null);
            if (!reminderSet)
            {
                Intent alarmIntent = new Intent(this, typeof(AlarmReceiver));
                PendingIntent pending = PendingIntent.GetBroadcast(Application.Context, 0, alarmIntent, PendingIntentFlags.UpdateCurrent);
                am = (AlarmManager)this.GetSystemService(AlarmService);

                DateTime currentTime = DateTime.Now;
                var triggerTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 6, 0, 0);
                var triggerSpan = TimeSpan.FromDays(1).Subtract(currentTime.Subtract(triggerTime));
                am.SetExact(AlarmType.ElapsedRealtimeWakeup, SystemClock.ElapsedRealtime() + (long)triggerSpan.TotalMilliseconds, pending);
                double tmp = triggerSpan.TotalMilliseconds;
                LongToast("You will be notified in : " + ((int)tmp / 3600000).ToString() + "Hours " + (((int)tmp % 3600000) / 60000).ToString() + "Minutes");
                reminderSet = true;
            }
        }
        private void GenerateOnClick(object sender, EventArgs eventArgs)
        {
            GenerateNames();
        }
        private void GenerateNames() {
            EditText boy = FindViewById<EditText>(Resource.Id.First);
            EditText girl = FindViewById<EditText>(Resource.Id.FirstG);
            boy.Text = boyName[rnd.Next(0, 499)];
            girl.Text = girlName[rnd.Next(0, 499)];
            EditText boyM = FindViewById<EditText>(Resource.Id.Middle);
            EditText girlM = FindViewById<EditText>(Resource.Id.MiddleG);
            boyM.Text = boyName[rnd.Next(0, 499)];
            girlM.Text = girlName[rnd.Next(0, 499)];
        }
        protected override void OnResume()
        {
            base.OnResume();
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {


            
        }
        private void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                // Notification channels are new in API 26 (and not a part of the
                // support library). There is no need to create a notification
                // channel on older versions of Android.
                return;
            }

            string name = "Local Notifications";
            var description = "The count from MainActivity.";
            var channel = new NotificationChannel(CHANNEL_ID, name, NotificationImportance.Default)
            {
                Description = description
            };

            NotificationManager notificationManager = (NotificationManager)this.GetSystemService(NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }
        public  void ShortToast(string message)
        {
            RunOnUiThread(delegate {
                Toast.MakeText(this, message, ToastLength.Short).Show();
            });
        }
        private void LongToast(string message)
        {
            RunOnUiThread(delegate {
                Toast.MakeText(this, message, ToastLength.Long).Show();
            });
        }
    }
}

[BroadcastReceiver]
public class AlarmReceiver : BroadcastReceiver
{
    public static long reminderInterval = AlarmManager.IntervalFifteenMinutes/15;
    static int NOTIFICATION_ID = 1000;
    static readonly string CHANNEL_ID = "location_notification";
    public AlarmReceiver()
    {
        

    }
    public override void OnReceive(Context context, Intent intent)
    {
        MainActivity.reminderSet = false;
            var builder = new NotificationCompat.Builder(Android.App.Application.Context, CHANNEL_ID)
          .SetAutoCancel(true) // Dismiss the notification from the notification area when the user clicks on it
          .SetContentTitle("Text Taylor") // Set the title
          .SetSmallIcon(Autotext.Resource.Drawable.Bell) // This is the icon to display
          .SetWhen(Java.Lang.JavaSystem.CurrentTimeMillis())
          .SetShowWhen(true)
          .SetContentText(DateTime.Now.ToString()); // the message to display.
            var notificationManager = NotificationManagerCompat.From(Android.App.Application.Context);
            notificationManager.Notify(NOTIFICATION_ID, builder.Build());       
    }
}





