# Setup

## Creating Your Very Own Fork

Do no clone this repository directly. Instead, rely on GitHub Classroom to
create a fork. Instructions should have been made available elsewhere
(presumably Toledo). If you can't find them, ask the lecturer.

Clone your repo using the following command, replacing `<<URL>>` by the url of your fork
(omit the `<` and `>`).

```bash
# Clone your repo
$ git clone <<URL>> picross

# Enter the repository
$ cd picross

# Add upstream remote
$ git remote add upstream https://github.com/UCLeuvenLimburg/picross-student
```

**Do not dare downloading the code as a zip.** You will be stripped
of your very existence, thereby ending up in Finland
where you'll have to watch The Last Airbender until you've learned your lesson.

Also, **do not clone your repository into a DropBox/OneDrive/Google Drive managed directory**.
The punishment for this is even worse, but it'll take us a while to determine
how we can top The Last Airbender.

## Opening in Visual Studio

Open the solution `PiCross.sln`. In the Solution Explorer,
right click View and choose Set as StartUp Project.

## GitHub

On the [main repository's website](https://github.com/UCLeuvenLimburg/picross-student),
click the Watch button in order to receive notifications about updates.

When updates are made, you can pull them as follows (note that you should first commit/stash all your changes, otherwise git might complain):

```bash
$ git pull upstream master
```
