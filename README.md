# Pretty Message Box

[![nuget badge](https://img.shields.io/nuget/v/PrettyMessageBox?logo=NuGet&style=for-the-badge)](https://www.nuget.org/packages/PrettyMessageBox)
[![nuget downloads badge](https://img.shields.io/nuget/dt/PrettyMessageBox?logo=NuGet&style=for-the-badge)](https://www.nuget.org/packages/PrettyMessageBox)
[![license badge](https://img.shields.io/github/license/gabriel-moresco/pretty-message-box?style=for-the-badge)](./LICENSE.txt)

A pretty `MessageBox` to use in your WPF projects

## Samples

```cs
MessageBox.Show("Title", "Test Content", ImageOptions.Checked);
```
![](https://raw.githubusercontent.com/gabriel-moresco/pretty-message-box/master/docs/sample_checked.png)

```cs
try
{
  ...something...
}
catch (Exception ex)
{
  MessageBox.Show("Title", "An error occurred:", ex);
}
```
![](https://raw.githubusercontent.com/gabriel-moresco/pretty-message-box/master/docs/sample_error.png)

```cs
MessageBox.Show("Title", "Test Content", ImageOptions.Info, ButtonOptions.OkCancel);
```
![](https://raw.githubusercontent.com/gabriel-moresco/pretty-message-box/master/docs/sample_info.png)

```cs
MessageBox.Show("Title", "Test Content", ImageOptions.Question, ButtonOptions.YesNoAuxiliary, "Test Aux");
```
![](https://raw.githubusercontent.com/gabriel-moresco/pretty-message-box/master/docs/sample_question.png)
