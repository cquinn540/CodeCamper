﻿using System;
using System.Collections.Generic;
using System.Linq;
using CodeCamper.Model;

namespace CodeCamper.SampleData
{
    public static class TheChosen
    {
        private static List<Person> _theChosen;
        private static Person 
            _johnPapa, _danWahlin, _wardBell, _hansFjallemark, 
            _jimCowart, _ryanNiemeyer, _scottGuthrie, _steveSanderson, 
            _aaronSkonnard, _fritzOnion, _scottHunter, _howardDierking, 
            _madsKristensen;

        /// <summary>Add the Chosen people</summary>
        public static void AddPersons(List<Person> persons)
        {
            _theChosen = new List<Person>();

            _theChosen.Add(_johnPapa = new Person
            {
                FirstName = "John",
                LastName = "Papa",
                Email = "johnp@contoso.com",
                Blog = "http://johnp.contoso.com",
                Twitter = "https://twitter.com/#!/john_papa",
                Gender = "M",
                Bio = "Husband and father enjoying every minute with my family. Microsoft Regional Director, Evangelist, speaker, and author for MSDN Magazine and Pluralsight.",
            });
            _theChosen.Add(_danWahlin =new Person
            {
                FirstName = "Dan",
                LastName = "Wahlin",
                Email = "danw@contoso.com",
                Blog = "http://danw.contoso.com",
                Twitter = "https://twitter.com/#!/danwahlin",
                Gender = "M",
                Bio = "Chief Architect at Wahlin Consulting. Provide consulting & training on jQuery, HTML5, ASP.NET, SharePoint. Husband & father, like to write and record music.",
            });
            _theChosen.Add(_wardBell = new Person
            {
                FirstName = "Ward",
                LastName = "Bell",
                Email = "wardb@contoso.com",
                Blog = "http://wardb.contoso.com",
                Twitter = "https://twitter.com/#!/wardbell",
                Gender = "M",
                Bio = "V.P. of Technology at IdeaBlade. Speaks often on client application development issues to anyone who will listen. Likes sociology, history, poetry, and ridiculous clothes.",
            });
            _theChosen.Add(_hansFjallemark = new Person
            {
                FirstName = "Hans",
                LastName = "Fjällemark",
                Email = "hansf@contoso.com",
                Blog = "http://hansf.contoso.com",
                Twitter = "https://twitter.com/#!/hfjallemark",
                Gender = "M",
                Bio = "Freelancing developer & designer based in Sweden. I spend most of my time implementing usable and attractive UX in HTML5 or Silverli.. no wait, just HTML5:) ",
            });
            _theChosen.Add(_jimCowart = new Person
            {
                FirstName = "Jim",
                LastName = "Cowart",
                Email = "jimc@contoso.com",
                Blog = "http://jimc.contoso.com",
                Twitter = "https://twitter.com/#!/ifandelse",
                Gender = "M",
                Bio = "Husband, father, architect, developer, tea drinker. Opinions are my own. Unless they're good",
            });
            _theChosen.Add(_ryanNiemeyer = new Person
            {
                FirstName = "Ryan",
                LastName = "Niemeyer",
                Email = "ryann@contoso.com",
                Blog = "http://ryann.contoso.com/",
                Twitter = "https://twitter.com/#!/rpniemeyer",
                Gender = "M",
                Bio = "Coder, tester, father, and husband. Never short on ideas. Love to learn and collaborate.",
            });
            _theChosen.Add(_scottGuthrie = new Person
            {
                FirstName = "Scott",
                LastName = "Guthrie",
                Email = "scottg@contoso.com",
                Blog = "http://scottg.contoso.com",
                Twitter = "https://twitter.com/#!/scottgu",
                Gender = "M",
                Bio = "I live in Seattle and build a few products for Microsoft",
            });
            _theChosen.Add(_steveSanderson = new Person
            {
                FirstName = "Steve",
                LastName = "Sanderson",
                Email = "steves@contoso.com",
                Blog = "http://steves.contoso.com",
                Twitter = "https://twitter.com/#!/stevensanderson",
                Gender = "M",
                Bio = "Also known as Steven Sanderson",
            });
            _theChosen.Add(_aaronSkonnard = new Person
            {
                FirstName = "Aaron",
                LastName = "Skonnard",
                Email = "aarons@contoso.com",
                Blog = "http://aarons.contoso.com",
                Twitter = "https://twitter.com/#!/skonnard",
                Gender = "M",
                Bio = "Changing the way software professionals learn. President/CEO of Pluralsight.",
            });
            _theChosen.Add(_fritzOnion = new Person
            {
                FirstName = "Fritz",
                LastName = "Onion",
                Email = "fritzo@contoso.com",
                Blog = "http://fritzo.contoso.com",
                Twitter = "",
                Gender = "M",
                Bio = "A co-founder of Pluralsight where he serves as the Editor in Chief.",
            });
            _theChosen.Add(_scottHunter = new Person
            {
                FirstName = "Scott",
                LastName = "Hunter",
                Email = "scotth@contoso.com",
                Blog = "http://scotth.contoso.com",
                Twitter = "https://twitter.com/#!/coolcsh",
                Gender = "M",
                Bio = "Program Manager at Microsoft on web technologies such as Azure, ASP.NET, MVC, Web API, Entity Framework, NuGet and more...",
            });
            _theChosen.Add(_madsKristensen = new Person
            {
                FirstName = "Mads",
                LastName = "Kristensen",
                Email = "madsk@contoso.com",
                Blog = "http://madsk.contoso.com",
                Twitter = "https://twitter.com/#!/mkristensen",
                Gender = "M",
                Bio = "Program Manager for Microsoft Web Platform & Tools and founder of BlogEngine.NET",
            });
            _theChosen.Add(_howardDierking = new Person
            {
                FirstName = "Howard",
                LastName = "Dierking",
                Email = "howardd@contoso.com",
                Blog = "http://howardd.contoso.com",
                Twitter = "https://twitter.com/#!/howard_dierking",
                Gender = "M",
                Bio = "I like technology...a lot...",
            });

            _theChosen.ForEach(p => p.ImageSource = 
                (p.FirstName + "_" + p.LastName + ".jpg").ToLowerInvariant());

            _hansFjallemark.ImageSource = "hans_fjallemark.jpg"; // get rid of 'ä'

            persons.AddRange(_theChosen);
        }

        /**
         * Hard-coded sessions for TheChoosen people
         * 
         * Speaker:
         *   Each "Chosen" one gets own variable (e.g., _scottGuthrie)
         *   as assigned in AddPersons method above.
         *   Organize your added sessions by person.
         *   
         * Rooms:
         *   Each person gets his/her own room (easier to prevent conflicts)
         *   taken from 'roomsForSessions' which are rooms NOT assigned during 
         *   session autogeneration; that constraint is obtained by limiting
         *   auto-generation session room assignment to the "Track Set" of rooms,
         *   the first 'n' rooms where 'n'==number of tracks.
         *   The remaining rooms are available for TheChoosen;
         *   (see the 'roomsForSessions' param).
         *   There is a nextRoomId variable to help you assign the next room
         *   when you start adding sessions for the next speaker.
         *   
         *   Make sure that the total number of rooms is adequate 
         *   (see CodeCamperDatabaseInitializer.cs)
         *   
         * TimeSlots:
         *   Only 'session' TimeSlots can be assigned (see the 'timeSlots' param).
         *   The first such TimeSlot is the keynote timeslot 
         *   which is assigned to Gu's keynote session.
         *   Subsequent addeded sessions are assigned round-robin, in order,
         *   to the non-keynote, session TimeSlots.
         *   (see getNextSpeakerTimeSlotId()).
         * 
         * Track: Hard coded for each session
         * 
         * Code:
         *   Each added session gets a 6 char "Code". 
         *   The naming convention is
         *       (1-3) are the three char SampleTrack.CodeRoot) +
         *       (4) the level (a number {1..3}) + 
         *       (5-6) two arbitrary digits.
         *       
         * The remaining session values are up to you.
         * 
         * ChoosenAttendeeSessions:
         *    These are the sessions which are the favorite of the
         *    well-known current user.
         *    
         *    You determine which sessions the current user has
         *    "favorited" (decided to attend) by setting the first
         *    parameter of the addSession method to 'true';
         *    the default is 'false', meaning that session is not
         *    the current user's "favorite."
         *    
         *    For example, Scott Gu's keynote has been favorited.
         *    
         *    Logic in CodeCamperDatabaseInitializer.AddAttendance
         *    arbitrarily assigns ratings and evals to the first
         *    'n' (n==4?) ChoosenAttendeeSessions.
         */
        public static List<Session> AddSessions(
            IList<TimeSlot> timeSlots,
            IList<Track> tracks,
            string[] levels,
            IList<Room> roomsForSessions)
        {

            var sessions = new List<Session>();
            ChoosenAttendeeSessions = new List<Session>();

            // Adds session to Sessions and optionally to ChoosenAttendeeSessions
            Func<bool, Session, Session> addSession = 
                (choosen, s) =>
                    {
                        sessions.Add(s);
                        if (choosen)
                        {
                            ChoosenAttendeeSessions.Add(s);  
                        } 
                        return s;
                    };

            // **Non-keynote** timeslot ids (the 1st is the keynote)
            var availableTimeSlotIds = timeSlots.Skip(1).Select(ts => ts.Id).ToArray();

            var nextSlotIx = -1;
            // Deterministic way to get id of next speaker timeslot
            Func<int> getNextSpeakerTimeSlotId =
                () =>
                    {
                       if (++nextSlotIx == availableTimeSlotIds.Count()) nextSlotIx = 0;
                        return availableTimeSlotIds[nextSlotIx];
                    };

            var nextRoomId = 0;

            // Scott Guthrie
            var roomId = roomsForSessions[nextRoomId++].Id;
            addSession(true, new Session
            {
                Title = "Keynote",
                Code = "KEY001",
                SpeakerId = _scottGuthrie.Id,
                TrackId = tracks.First(t => t.Name == ".NET").Id,
                TimeSlotId = timeSlots[0].Id,
                RoomId = roomId,
                Level = levels[1],
                Tags = "Keynote",
                Description = "",
            });
            addSession(false, new Session
            {
                Title = "MVC 4 in Perspective",
                Code = "ASP162",
                SpeakerId = _scottGuthrie.Id,
                TrackId = tracks.First(t => t.Name == "ASP.NET").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[1],
                Tags = "ASP|MVC|Web",
                Description =
                    "MVC 4 enables a wider variety of web applications than ever before. The libraries that are easily managed through Nuget and are truly opens source. Learn about the new capabilities and how you can contribute to ASP.NET MVC's evolution.",
            });

            //Scott Hunter
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(true, new Session
            {
                Title = "Azure: to the Cloud",
                Code = "CLD163",
                SpeakerId = _scottHunter.Id,
                TrackId = tracks.First(t => t.Name == "Cloud").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[1],
                Tags = "Cloud|Azure|Node|Web",
                Description = "Windows Azure offers reliable, affordable cloud computing for almost any application of any scale, built with any technology. Scott demonstates with examples of both Windows and non-Windows applications.",
            });
                
            // John Papa
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(true, new Session
            {
                Title = "Building HTML/JavaScript Apps with Knockout and MVVM",
                Code = "JVS300",
                SpeakerId = _johnPapa.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "JavaScript|Knockout|MVVM|HTML5|Web",
                Description =
                    "Do you write a lot of HTML and JavaScript code to push and pull data? In this session, learn popular techniques to use data binding to bind your data to your target controls in HTML writing less code, but gaining more power. See how to consume json data, use json objects in JavaScript, use declarative binding, using KnockoutJS. Also, see how to use the MVVM pattern to write data centric JavaScript code that follows good separation patterns and creates highly maintainable code.",
            });
            addSession(false, new Session
            {
                Title = "JsRender Fundamentals",
                Code = "JVS201",
                SpeakerId = _johnPapa.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[1],
                Tags = "JavaScript|JsRender|Web",
                Description =
                    "Learn how to build fast, robust, and maintainable Web applications with JavaScript, jQuery and JsRender: the successor to jQuery Templates.",
            });
            addSession(true, new Session
            {
                Title = "Introduction to Building Windows 8 Metro Applications",
                Code = "WIN102",
                SpeakerId = _johnPapa.Id,
                TrackId = tracks.First(t => t.Name == "Windows 8").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[0],
                Tags = "Windows|Metro",
                Description =
                    "This session covers everything you need to know to get started building Metro apps.",
            });
            addSession(true, new Session
            {
                Title = "Build a Custom Single Page Application",
                Code = "JVS277",
                SpeakerId = _johnPapa.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "Knockout|JavaScript|Web",
                Description =
                    "Build a SPA, then hang out in one.",
            });

            // Dan Wahlin
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(false, new Session
            {
                Title = "Building ASP.NET MVC Apps with EF Code First, HTML5, and jQuery",
                Code = "ASP310",
                SpeakerId = _danWahlin.Id,
                TrackId = tracks.First(t => t.Name == "ASP.NET").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "MVC|HTML5|Entity Framework|jQuery|Web",
                Description = "This session provides an end-to-end look at building a Web application using several different technologies.",
            });
            addSession(false, new Session
            {
                Title = "jQuery Fundamentals",
                Code = "JVS111",
                SpeakerId = _danWahlin.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[0],
                Tags = "jQuery|JavaScript|Web",
                Description =
                    "This session guides you through the features of the jQuery \"write less, do more\" library",
            });

            // Mads Kristensen
            addSession(true, new Session
            {
                Title = "Structuring JavaScript Code",
                Code = "JVS212",
                SpeakerId = _madsKristensen.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[1],
                Tags = "Web Forms|ASP|Web",
                Description =
                    "This session walks through several key patterns that can be used to encapsulate and modularize JavaScript code. Throughout the course you’ll learn how closures and other techniques can be used to better organize your JavaScript code and make it easier to re-use and maintain in HTML5 applications.",
            });

            // Ward Bell
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(false, new Session
            {
                Title = "Dressing for Success",
                Code = "DSN320",
                SpeakerId = _wardBell.Id,
                TrackId = tracks.First(t => t.Name == "Design").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "Design|Animation|Metro",
                Description = "You must have style to design with style. A proper wardrobe is an essential first step to application success. Learn to dress from this old pro.",
            });
            addSession(false, new Session
            {
                Title = "Entity Framework for Poets",
                Code = "DAT121",
                SpeakerId = _wardBell.Id,
                TrackId = tracks.First(t => t.Name == "Data").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[0],
                Tags = "Data|Entity Framework|ORM",
                Description =
                    "If you can pronounce 'O-R-M', you're on your way to a lucrative career in the fast-paced world of data processing. Discover how Entity Framework can make you a star, in the office and around town.",
            });
            addSession(true, new Session
            {
                Title = "A JavaScript Toolbox",
                Code = "JVS222",
                SpeakerId = _wardBell.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[1],
                Tags = "JavaScript|Web",
                Description =
                    "You need a good set of tools to be a rock star JavaScript developer. What does Ward use to write, test and debug? Come to this session and find out.",
            });

            // Howard Dierking
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(false, new Session
            {
                Title = "ASP.NET MVC 4 Loves HTML5",
                Code = "ASP333",
                SpeakerId = _howardDierking.Id,
                TrackId = tracks.First(t => t.Name == "ASP.NET").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "MVC|HTML5|Entity Framework|jQuery|Web",
                Description = "TBD",
            });

            // Hans Fjällemark
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(false, new Session
            {
                Title = "Bootstrap and Back",
                Code = "CSS132",
                SpeakerId = _hansFjallemark.Id,
                TrackId = tracks.First(t => t.Name == "CSS").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[0],
                Tags = "CSS|Responsive Design|Web",
                Description =
                    "TBD",
            });
            addSession(true, new Session
            {
                Title = "Responsive Web Design with CSS3",
                Code = "CSS233",
                SpeakerId = _hansFjallemark.Id,
                TrackId = tracks.First(t => t.Name == "CSS").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[1],
                Tags = "CSS3|Responsive Design|Web",
                Description =
                    "TBD",
            });

            // Jim Cowart
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(false, new Session
            {
                Title = "Jim Cowart Underscores",
                Code = "JVS340",
                SpeakerId = _jimCowart.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "JavaScript|Underscore|jQuery|Web",
                Description = "TBD",
            });
            addSession(false, new Session
            {
                Title = "Straighten Your Backbone with Jim Cowart",
                Code = "JVS141",
                SpeakerId = _jimCowart.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[0],
                Tags = "Backbone|JavaScript|Web",
                Description =
                    "TBD",
            });

            // Steve Sanderson
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(true, new Session
            {
                Title = "Going for the Knockout",
                Code = "JVS242",
                SpeakerId = _steveSanderson.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "Knockout|JavaScript|Web",
                Description =
                    "TBD",
            });
            addSession(true, new Session
            {
                Title = "The Upshot is ...",
                Code = "JVS250",
                SpeakerId = _steveSanderson.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "Knockout|JavaScript|Web",
                Description =
                    "TBD",
            });

            // Ryan Niemeyer
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(true, new Session
            {
                Title = "Knockback a few cold ones",
                Code = "JVS351",
                SpeakerId = _ryanNiemeyer.Id,
                TrackId = tracks.First(t => t.Name == "ASP.NET").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "JavaScript|Knockout|jQuery|Web",
                Description = "TBD",
            });
            addSession(false, new Session
            {
                Title = "Knockout Performance Gotchas",
                Code = "JVS152",
                SpeakerId = _ryanNiemeyer.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[0],
                Tags = "Knockout|JavaScript|Web",
                Description = "TBD",
            });
            addSession(false, new Session
            {
                Title = "The Expert jsFiddler",
                Code = "JVS253",
                SpeakerId = _ryanNiemeyer.Id,
                TrackId = tracks.First(t => t.Name == "JavaScript").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[1],
                Tags = "jsFiddle|JavaScript|Web",
                Description = "TBD",
            });

            // Aaron Skonnard
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(true, new Session
            {
                Title = "Web Services at their Finest",
                Code = "JVS351",
                SpeakerId = _aaronSkonnard.Id,
                TrackId = tracks.First(t => t.Name == ".NET").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[2],
                Tags = "WCF|REST|Web",
                Description = "TBD",
            });

            // Fritz Onion
            roomId = roomsForSessions[nextRoomId++].Id;
            addSession(true, new Session
            {
                Title = "What's New in ASP.NET 4",
                Code = "ASP141",
                SpeakerId = _fritzOnion.Id,
                TrackId = tracks.First(t => t.Name == "ASP.NET").Id,
                TimeSlotId = getNextSpeakerTimeSlotId(),
                RoomId = roomId,
                Level = levels[1],
                Tags = "ASP.NET|Web",
                Description = "TBD",
            });
            
            return sessions;
        }

        public static List<Session> ChoosenAttendeeSessions { get; private set; }

    }
}
