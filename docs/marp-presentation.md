---
marp: true
theme: gaia
---
<style>
    @import url('https://fonts.googleapis.com/css2?family=JetBrains+Mono:wght@400&display=swap');
    
    :root {
        --color-background: #282c34;
        --color-foreground: #949aa8;
        font-family: 'JetBrains Mono', monospace;
        
    }

    img[alt~="center"] {
        display: block;
        margin: 0 auto;
    }

    h1 {
        font-size: 45px;
        color: #61afef;
    }

    h2 { font-size: 40px;}

    h3 { font-size: 30px;
    color: #c678dd;}

    h4 { 
        font-size: 25px;
        color: #98c379;
    }

    h5 { font-size: 20px;}

    h6 { font-size: 18px;}

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
   color: #aab2be
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
![h:380 center drop-shadow](https://i.imgur.com/NyXi2Xj.png) 


#### By Joshua Macauley ([@Macawls][macawls]) ![w:2em h:2em](https://avatars.githubusercontent.com/u/80009513?v=4) 
##### View the presentation in your browser at [macawls.dev/unitydeployexample](https://macawls.dev/unitydeployexample)

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

![bg left:40% h:500 drop-shadow](https://media.giphy.com/media/XMC67UHffXHrUIJGpn/giphy.gif)


--- 

# The problem continued

There's a hour left, everyone is exhausted.

You have to manually fetch the latest change and build the project.

Suddenly there's a problem with the build without much time to fix it.

![bg right h:500 drop-shadow](https://i.giphy.com/efFHPJWv9tzuB6lDZs.gif)

--- 
# The Solution! What is CI/CD? <!--fit-->


![bg left:33% h:300](https://i.kym-cdn.com/photos/images/original/001/385/979/26b.png)

* CI - Continous Integration
* CD - Continous Deployment

### Definiton
"CI/CD is a method to frequently deliver apps to customers by introducing **automation** into the stages of app development."

---
# Development and Operations(DevOps) Pipeline <!--fit-->
![center h:540](https://i.imgur.com/NyXi2Xj.png) 

---
# What is Github Actions? 
"GitHub Actions is a continuous integration and continuous delivery (CI/CD) platform that allows you to automate your build, test, and deployment pipeline."

![h:420 center](https://github.githubassets.com/images/modules/site/features/actions-workflow.svg)

___
# What can I do with GitHub Actions? 
### Many things!

![bg right:40% h:600 center](https://i.imgur.com/tKw28I3.png)
* Automatically **publish** your game to multiple stores!
---

# Hope you enjoyed! :v: <!--fit-->

## Happy developing! 💻