// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;

namespace SimpleFATFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFATFileSystem("myfilesystem.img");
        }

        static void CreateFATFileSystem(string imageFileName)
        {
            int totalSectors = 2880; // Example value for a 1.44MB floppy disk image
            int sectorsPerCluster = 1;
            int bytesPerSector = 512;

            using (FileStream fs = new FileStream(imageFileName, FileMode.Create, FileAccess.ReadWrite))
            {
                // Create a simple boot sector
                byte[] bootSector = new byte[bytesPerSector];
                // Populate the boot sector fields here
                // ...

                // Write the boot sector to the image file
                fs.Write(bootSector, 0, bytesPerSector);

                // Calculate cluster-related values
                int reservedSectors = 1;
                int fatSize = totalSectors / sectorsPerCluster / 2;
                int rootDirEntries = 224;
                int rootDirSectors = (rootDirEntries * 32 + bytesPerSector - 1) / bytesPerSector;
                int firstDataSector = reservedSectors + fatSize * 2 + rootDirSectors;
                int dataAreaSectors = totalSectors - firstDataSector;

                // Create a simple File Allocation Table (FAT)
                byte[] fat = new byte[fatSize * bytesPerSector];
                // Initialize the FAT entries here
                // ...

                // Write the FAT to the image file
                fs.Write(fat, 0, fat.Length);

                // Create a simple root directory
                byte[] rootDir = new byte[rootDirSectors * bytesPerSector];
                // Create directory entries here
                // ...

                // Write the root directory to the image file
                fs.Write(rootDir, 0, rootDir.Length);

                // Create a simple data area (empty in this example)
                byte[] dataArea = new byte[dataAreaSectors * bytesPerSector];
                // ...

                // Write the data area to the image file
                fs.Write(dataArea, 0, dataArea.Length);
            }

            Console.WriteLine("FAT filesystem image created successfully.");
        }
    }
}
