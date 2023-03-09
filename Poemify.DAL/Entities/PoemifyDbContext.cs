using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.DAL.Entities
{
    public class PoemifyDbContext : DbContext
    {
        public PoemifyDbContext(DbContextOptions<PoemifyDbContext> options):base(options)
        {

        }

       /* public static IEnumerable<User> GetUsersWithPoems()
        {
            return new List<User>() {
             new User{
                 FullName = "Odogwu Cee",
                 Email = "Odogwu@mail.com",
                 Password= "P@ssword",
                 Poems = new List<Poem> ()
                 {
                     new Poem
                     {
                         Id= 1,
                         Name = "Spring",
                         Body = @"
It's not yet spring
Yet I anticipate your call
Waiting for my phone to ring
While tears from my face fall

It's not yet spring
Yet they're butterflies
In my garden forming a ring
Around where your body lies

It's not yet spring
Yet you are here with me
And my tears flow like a spring
As memories sting me like a bee

It's not yet spring 
Yet the flowers bloom
Good tidings may it bring
To my soul of gloom


                                                           ~ C.Charles C C
"

                     },
                      new Poem
                     {
                         Id = 2,
                         Name = "Time",
                         Body = @"
Seemingly slow, yet passes quickly
The bane of all things ephemeral
The ultimate test of the universe
An ultimate sage, very renowned
Teaching those who wish, wisdom

An archival of the past
A diary of the present 
An oracle of the future 
You who never stops
But never ends

Precious to the knowledgeable
Insignificant to the ignorant
The greatest resource,
The difference maker
A priceless treasure, unappreciated 



                                        ~ C.Charles C C
"

                     },

                 }
             },
            new User{
                 FullName = "Cee Cee Cee",
                 Email = "CeeCee@mail.com",
                 Password= "P@ssw0rd",
                 Poems = new List<Poem> ()
                 {
                     new Poem
                     {
                         Id = 1,
                         Name = "Farewell?",
                         Body = @"
The nights turned to days
The connection had strains
Our hearts' symphony
Turned cacophony

Why has our chattering
Our endless bantering
Turned quarrelling,
And silence, frightening?

Pain burns in my heart
It's been hit by a dart
The fear that never was
Isn't far from a reality 



                                                       ~C.Charles C C"

                     },
                      new Poem
                     {
                         Id = 1,
                         Name = "Te Amor",
                         Body = @"
Some people stay for a while, others forever
Every day, I pray you're the latter 
But if you must go, stay a while longer
Because when the sun sinks into the horizon
I want you smiling by my side
Your hands entwined with mine
I'll never let you go.

I bless fate for crossing our paths
I mean this from my heart's depth
You proved that though the stars are bright
Your smile is brighter
Even in the darkest nights, fighting my demons
You opened your arms and gave comfort,
You stretched your kindness to my soul

Home? Yeah! You're my home
A place I long for more than your arms?
No! That place doesn't exist
Eternity sounds overwhelming
But your love overwhelms it
The brightest of your smile
Makes the stars jealous 

❣️ I love you ❣️

                                                   ~C.Charles C C
"

                     },

                 }
             }
            };
        }*/
    }
}
