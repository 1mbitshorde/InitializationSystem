# Initialization System

Initialization code to load global dependencies.

## How To Use

### Using DependencyInstantiater

Instantiates a "Dependencies" Prefab via Addressables into the **DontDestroyOnLoad Scene** when the game enters in Play mode for any Scene.

![Dont Destroy On Load](/Docs~/DontDestroyOnLoad.png "DontDestroyOnLoad")

>**Note**: name your Prefab as Dependencies and set it as addressable using the same name.

### Using DependencyInstantiateHandler

Executes an **UnityEvent** when **DependencyInstantiater** finishes to instantiate all dependencies.

## Installation

### Using the Git URL

You will need a **Git client** installed on your computer with the Path variable already set and the correct git credentials to 1M Bits Horde.

- In this repo, go to Code button, select SSH and copy the URL.
- In Unity, use the **Package Manager** "Add package from git URL..." feature and paste the URL.
- Set the version adding the suffix `#[x.y.z]` at URL

---

**1 Million Bits Horde**

[Website](https://www.1mbitshorde.com) -
[GitHub](https://github.com/1mbitshorde) -
[LinkedIn](https://www.linkedin.com/company/1m-bits-horde)
