			 <!--Talking points!
			* Introduction
			* Out of the box, just a text editor
			* Rediculously customizable (replace mouse with stupid image)
			* Built in terminals 
			* Tasks
			* Debugging
			* Built in git support
			* Extensions
			** Chrome debugger
			** c# stuff
			** Code Runner
			** Powershell
			** JSHint
			** Code Spellchecker
			* Markdown preview
      <section>
	<pre><code data-trim data-noescape>
(def lazy-fib
  (concat
   [0 1]
   <mark>((fn rfib [a b]</mark>
        (lazy-cons (+ a b) (rfib b (+ a b)))) 0 1)))
	</code></pre>
</section>
			-->

# Visual Studio Code
Presentation by Tyler Palesano  
[@TPalesano](https://twitter.com/TPalesano)

Note: Press `s`. `esc` to see map. Arrow keys to use slides. Get a PowerShell terminal running for Example 1

---

## It's a text editor.

Note: Press down arrow

vvv

# Thank you

* Twitter: [@TPalesano](https://twitter.com/TPalesano)
* Presentation: [github.com/MrOnosa/vscode](https://github.com/MrOnosa/vscode)
* Created using: [reveal.js](https://github.com/hakimel/reveal.js/)

Note: Worst timeline

---

## It's a ridiculously customizable text editor with handy bells and whistles

Note: Built in terminals, Customizable Tasks, Debugging, Built in git support, Extensions (Chrome debugger, c# stuff), Markdown preview

---

### IDE Continuum

| Notepad++ | VS Code | VS2017 |
| :--- | :--- | :--- |
| Single Simple file | - Directory <br> - Scripting files <br> - Unity | Entire solution |

Note: Talk about Directory. Scripting files meaning JavaScript or PowerShell. Discus why I used VS Code to begin with (Drawing Tool).
---

## CUSTOMIZABLE

My Settings. Lots to choose from with every update.

```
{
"workbench.colorTheme": "Visual Studio Dark",
"files.autoSave": "afterDelay",
"files.autoSaveDelay": 200,
"editor.autoClosingBrackets": false,
"editor.dragAndDrop": true,
"terminal.integrated.shell.windows": 
	"C:\\Windows\\System32\\cmd.exe",
"editor.cursorBlinking": "smooth"
}
```

Note: Show IntelliSense Open settings.json with >Preferences: Open User Settings. 

---

## Snippets and IntelliSense

* Contextually aware snippet
	1. Use `ctrl` + `shift` + `p` 
	2. Type `>Insert Snippet`
* Contextually aware IntelliSense
	1. Use `ctrl` + `space`

---

## Terminals

Use multiple terminals within VS Code

Note: Show terminals. Hit plus size. update settings.json and open powershell.

vvv

## Command Prompt
![CMD](./slides/cmd.png)

vvv

## Bash
![$](./slides/bash.png)

vvv

## Windows PowerShell
![PS](./slides/powershell.png)

Note: Time for Example 1

---

## Tasks

* Runs commands
	* Grunt, dotnet, batch, whatever
* Assignable to keyboard shortcuts
* Can be set as a preLaunchTask action
* Currently running this presentation
* Not as nice as I'd like

Note: Using a task to run this presentation. Discuss my confusing with using multiple tasks that rely on different shells.

---

# Debugging

* Out of the box Node.js support
* Extensions for other stuff

Note: Example 2 & 3

---

# Extensions

---

# Thank you

* Twitter: [@TPalesano](https://twitter.com/TPalesano)
* Presentation: [github.com/MrOnosa/vscode](https://github.com/MrOnosa/vscode)
* Created using: [reveal.js](https://github.com/hakimel/reveal.js/)

Note: True Pacifist Route ending