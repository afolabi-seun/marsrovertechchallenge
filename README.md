# marsrovertechchallenge
The Mars Rover Challenge

# assumptions
In my code, i am making assumptions that there maybe multiple rovers, so i have created a textfile(test.txt) within the Resources folder to simulate this example.
I wrote a funtion to map the textfile to instruction class, this map funtion does not validate the class

# documentation
Document the project including how one would install and run your programme with an example.

To install a console app program on a remote machine using C#, you can use a combination of C# code and command-line tools such as PowerShell or PsExec. Here are the high-level steps you can follow:

1. Package the console app program into an installer or zip file that can be copied to the remote machine.
2. Connect to the remote machine using a remote access protocol such as SSH or RDP.
3. Copy the installer or zip file to the remote machine using a file transfer protocol such as SCP or SMB.
4. Unzip or extract the program files on the remote machine.
5. Use a command-line tool such as PowerShell or PsExec to run the installer or execute the console app program.

# sample code
using System.Diagnostics;

//connect to the remote machine using PowerShell
Process process = new Process();
ProcessStartInfo startInfo = new ProcessStartInfo();
startInfo.FileName = "powershell.exe";
startInfo.Arguments = $"Enter-PSSession -ComputerName {remoteMachineName} -Credential (Get-Credential)";
startInfo.RedirectStandardOutput = true;
startInfo.UseShellExecute = false;
startInfo.CreateNoWindow = true;
process.StartInfo = startInfo;
process.Start();

//copy the installer or zip file to the remote machine using SMB
Process.Start("cmd.exe", $"/c copy {localFilePath} \\\\{remoteMachineName}\\C$\\temp");

//unzip or extract the program files on the remote machine
Process.Start("cmd.exe", $"/c expand {remoteFilePath} {remoteInstallPath}");

//run the installer or execute the console app program using PsExec
Process.Start("cmd.exe", $"/c psexec.exe \\\\{remoteMachineName} {remoteInstallPath}\\{executableName} {arguments}");

