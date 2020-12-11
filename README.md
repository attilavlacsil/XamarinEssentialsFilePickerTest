# XamarinEssentialsFilePickerTest

## Exception

`12-11 11:35:48.730 E/mono    ( 2928): Unhandled Exception:
12-11 11:35:48.730 E/mono    ( 2928): System.UnauthorizedAccessException: Access to the path "/storage/emulated/0/testfile.txt" is denied.
12-11 11:35:48.730 E/mono    ( 2928):   at System.IO.FileStream..ctor (System.String path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, System.Int32 bufferSize, System.Boolean anonymous, System.IO.FileOptions options) [0x001aa] in /Users/builder/jenkins/workspace/archive-mono/2020-02/android/release/mcs/class/corlib/System.IO/FileStream.cs:239 
12-11 11:35:48.730 E/mono    ( 2928):   at System.IO.FileStream..ctor (System.String path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) [0x00000] in /Users/builder/jenkins/workspace/archive-mono/2020-02/android/release/mcs/class/corlib/System.IO/FileStream.cs:91 
12-11 11:35:48.730 E/mono    ( 2928):   at (wrapper remoting-invoke-with-check) System.IO.FileStream..ctor(string,System.IO.FileMode,System.IO.FileAccess,System.IO.FileShare)
12-11 11:35:48.730 E/mono    ( 2928):   at System.IO.File.OpenRead (System.String path) [0x00000] in /Users/builder/jenkins/workspace/archive-mono/2020-02/android/release/external/corefx/src/System.IO.FileSystem/src/System/IO/File.cs:266 
12-11 11:35:48.730 E/mono    ( 2928):   at Xamarin.Essentials.FileBase.PlatformOpenReadAsync () [0x00000] in D:\a\1\s\Xamarin.Essentials\FileSystem\FileSystem.android.cs:368 
12-11 11:35:48.730 E/mono    ( 2928):   at Xamarin.Essentials.FileBase.OpenReadAsync () [0x00000] in D:\a\1\s\Xamarin.Essentials\FileSystem\FileSystem.shared.cs:172 
12-11 11:35:48.730 E/mono    ( 2928):   at XamarinEssentialsFilePickerTest.MainPage.ReadFileAsync () [0x000f5] in C:\VS\XamarinEssentialsFilePickerTest\XamarinEssentialsFilePickerTest\XamarinEssentialsFilePickerTest\MainPage.xaml.cs:39 
12-11 11:35:48.730 E/mono    ( 2928):   at XamarinEssentialsFilePickerTest.MainPage.Button_OnClicked (System.Object sender, System.EventArgs e) [0x00020] in C:\VS\XamarinEssentialsFilePickerTest\XamarinEssentialsFilePickerTest\XamarinEssentialsFilePickerTest\MainPage.xaml.cs:19 
12-11 11:35:48.730 E/mono    ( 2928):   at (wrapper dynamic-method) Android.Runtime.DynamicMethodNameCounter.1(intptr,intptr)
12-11 11:35:48.730 E/mono    ( 2928):   at (wrapper native-to-managed) Android.Runtime.DynamicMethodNameCounter.1(intptr,intptr)
12-11 11:35:48.730 E/mono-rt ( 2928): [ERROR] FATAL UNHANDLED EXCEPTION: System.UnauthorizedAccessException: Access to the path "/storage/emulated/0/testfile.txt" is denied.
12-11 11:35:48.730 E/mono-rt ( 2928):   at System.IO.FileStream..ctor (System.String path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, System.Int32 bufferSize, System.Boolean anonymous, System.IO.FileOptions options) [0x001aa] in /Users/builder/jenkins/workspace/archive-mono/2020-02/android/release/mcs/class/corlib/System.IO/FileStream.cs:239 
12-11 11:35:48.730 E/mono-rt ( 2928):   at System.IO.FileStream..ctor (System.String path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) [0x00000] in /Users/builder/jenkins/workspace/archive-mono/2020-02/android/release/mcs/class/corlib/System.IO/FileStream.cs:91 
12-11 11:35:48.730 E/mono-rt ( 2928):   at (wrapper remoting-invoke-with-check) System.IO.FileStream..ctor(string,System.IO.FileMode,System.IO.FileAccess,System.IO.FileShare)
12-11 11:35:48.730 E/mono-rt ( 2928):   at System.IO.File.OpenRead (System.String path) [0x00000] in /Users/builder/jenkins/workspace/archive-mono/2020-02/android/release/external/corefx/src/System.IO.FileSystem/src/System/IO/File.cs:266 
12-11 11:35:48.730 E/mono-rt ( 2928):   at Xamarin.Essentials.FileBase.PlatformOpenReadAsync () [0x00000] in D:\a\1\s\Xamarin.Essentials\FileSystem\FileSystem.android.cs:368 
12-11 11:35:48.730 E/mono-rt ( 2928):   at Xamarin.Essentials.FileBase.OpenReadAsync () [0x00000] in D:\a\1\s\Xamarin.Essentials\FileSystem\FileSystem.shared.cs:172 `
