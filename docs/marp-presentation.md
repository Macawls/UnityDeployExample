---
marp: true
theme: gaia
---
<style>
    @import url('https://fonts.googleapis.com/css2?family=JetBrains+Mono:wght@400&display=swap');
    
    :root {
        --color-background: #282c34;
        --color-foreground: #abb2bf;
        font-family: 'JetBrains Mono', monospace;
        
    }

    img[alt~="center"] {
        display: block;
        margin: 0 auto;
    }

    h1 {
        font-size: 50px;
        color: #61afef;
    }

    h2 { font-size: 40px;}

    h3 { font-size: 30px;}

    h4 { font-size: px;}

    h5 { font-size: 28px;}

    a {
        color: #e5c07b;
    }

    p {
        font-size: 28px;
    }

    ul {
        font-size: 32px;
        list-style: none;
    }

    b, strong {
   color: #cccdcd
    }

    
ul li::before {
  content: "\2022"; 
  color: #c678dd; /* Change the color */
  font-weight: bold;
  display: inline-block;
  size: 5em; 
  width: 1em;
  margin-left: -1em; 
}

</style>
[macawls]: https://github.com/macawls 
# CI/CD for your Unity Projects 

### Working more efficiently as a Game Developer
![h:300 center](images/cicd.png) 


##### By Joshua Macauley ([@Macawls][macawls]) ![w:2em h:2em](https://avatars.githubusercontent.com/u/80009513?v=4) 
##### View the presentation in your browser at [macawls.dev/deployexample](https://macawls.dev/deployexample)

---

# A little bit about me

![h:260 center](https://i.imgur.com/AQhE3Pp.png)

* I've always enjoyed messing with things!
* Linux and Open-Source :heart:
* DRY -> Don't repeat yourself!
* RTFM -> [Read the fucking manual](http://readthefuckingmanual.com/)

---

# Lets outline the problem

You're working with a **team of four** during the **Game Jam**.

Bob wants to **playtest** Timmy's **changes**.

**Adam**, the **artist** who **doesn't know how to use Github** wants to test the game.

![bg left h:500](https://media.giphy.com/media/XMC67UHffXHrUIJGpn/giphy.gif)


--- 

# The problem continued

There's a hour left, everyone is exhausted.

You have to manually fetch the latest change and build the project.

Suddenly there's a problem with the build without much time to fix it.

![bg right h:500](https://i.giphy.com/efFHPJWv9tzuB6lDZs.gif)


---

# Hope you enjoyed! :v: <!--fit-->

## Happy developing! 💻