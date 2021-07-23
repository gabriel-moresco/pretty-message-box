# Pretty Message Box

[![nuget badge](https://img.shields.io/nuget/v/PrettyMessageBox?logo=NuGet&style=for-the-badge)](https://www.nuget.org/packages/PrettyMessageBox)
[![nuget downloads badge](https://img.shields.io/nuget/dt/PrettyMessageBox?logo=NuGet&style=for-the-badge)](https://www.nuget.org/packages/PrettyMessageBox)
[![license badge](https://img.shields.io/github/license/gabriel-moresco/pretty-message-box?style=for-the-badge)](./LICENSE.txt)

A `PrettyMessageBox` to use in your WPF projects

## Usage

```cs
PrettyMessageBox.Show("Title", "Test Content", ImageOptions.Checked);
```
![](https://raw.githubusercontent.com/gabriel-moresco/pretty-message-box/master/docs/sample_checked.png)

```cs
try
{
    //...SOMETHING THAT THROWS AN EXCEPTION...
    int.Parse("");
}
catch (Exception ex)
{
    PrettyMessageBox.Show("Title", "An error occurred:", ex);
}
```
![](https://raw.githubusercontent.com/gabriel-moresco/pretty-message-box/master/docs/sample_error.png)
![](https://raw.githubusercontent.com/gabriel-moresco/pretty-message-box/master/docs/sample_exception_details.png)

```cs
MessageBoxResults result = PrettyMessageBox.Show("Title", "Test Content", ImageOptions.Info, ButtonOptions.OkCancel);
```
![](https://raw.githubusercontent.com/gabriel-moresco/pretty-message-box/master/docs/sample_info.png)

```cs
MessageBoxResults result = PrettyMessageBox.Show("Title", "Test Content", ImageOptions.Question, ButtonOptions.YesNoAuxiliary, "Test Aux");
```
![](https://raw.githubusercontent.com/gabriel-moresco/pretty-message-box/master/docs/sample_question.png)
