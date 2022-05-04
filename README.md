# WPF - View Model Code Generator for MVVM Light

The free DevExpress MVVM Code Generator helps you avoid boilerplate code in your view model. It supports the following MVVM Light view model features:

* Commands

    ```csharp
    //synchronous command
    [GenerateCommand]
    public void SomeMethod (int? commandParameter) => {
        MessageBox.Show(“Simple Command”);
    }

    //asynchronous command
    [GenerateCommand]
    public Task SomeAsyncMethod (int? commandParameter) => {
        return Task.CompletedTask;
    }
    ```

* ICleanup interface

    ```csharp
    [GenerateViewModel(ImplementICleanup = true)]
    public partial class MainViewModel {
        public void OnCleanup() {
            // ...
        }
    }
    ```

The generator also supports standard view model features, such as automatically generated properties with INotifyPropertyChanged and INotifyPropertyChanging implementation:

```csharp
[GenerateProperty]
bool message;
```

The following topic lists all supported PRISM features: [Third-party Libraries Support -> MVVM Light Toolkit](https://docs.devexpress.com/WPF/402989/mvvm-framework/viewmodels/compile-time-generated-viewmodels#third-party-libraries-support).