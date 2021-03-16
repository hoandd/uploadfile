using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace uploadfile.Base
{
    public interface PhysicalFileProviderBase: FileProviderBase
    {       

        void RootFolder(string folderName);
        void SetRules(AccessDetails details);
    }
    public interface FileProviderBase
    {
        FileManagerResponse Copy(string path, string targetPath, string[] names, string[] renameFiles, FileManagerDirectoryContent TargetData, params FileManagerDirectoryContent[] data);
        FileManagerResponse Create(string path, string name, params FileManagerDirectoryContent[] data);
        FileManagerResponse Delete(string path, string[] names, params FileManagerDirectoryContent[] data);
        FileManagerResponse Details(string path, string[] names, params FileManagerDirectoryContent[] data);
        FileStreamResult Download(string path, string[] names, params FileManagerDirectoryContent[] data);
        FileManagerResponse GetFiles(string path, bool showHiddenItems, params FileManagerDirectoryContent[] data);
        FileStreamResult GetImage(string path, string id, bool allowCompress, ImageSize size, params FileManagerDirectoryContent[] data);
        FileManagerResponse Move(string path, string targetPath, string[] names, string[] renameFiles, FileManagerDirectoryContent TargetData, params FileManagerDirectoryContent[] data);
        FileManagerResponse Rename(string path, string name, string newName, bool replace = false, params FileManagerDirectoryContent[] data);
        FileManagerResponse Search(string path, string searchString, bool showHiddenItems, bool caseSensitive, params FileManagerDirectoryContent[] data);
        FileManagerResponse Upload(string path, IList<IFormFile> uploadFiles, string action, params FileManagerDirectoryContent[] data);
    }
    public class FileManagerResponse
    {
        public FileManagerResponse()
        {

        }

        public FileManagerDirectoryContent CWD { get; set; }
        public IEnumerable<FileManagerDirectoryContent> Files { get; set; }
        public ErrorDetails Error { get; set; }
        public FileDetails Details { get; set; }
    }
    public class FileDetails
    {
        public FileDetails() { }

        public string Name { get; set; }
        public string Location { get; set; }
        public bool IsFile { get; set; }
        public string Size { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool MultipleFiles { get; set; }
        public AccessPermission Permission { get; set; }
    }
    public class AccessPermission
    {
        public bool Copy;
        public bool Download;
        public bool Write;
        public bool WriteContents;
        public bool Read;
        public bool Upload;
        public string Message;

        public AccessPermission() { }
    }
    public class ErrorDetails
    {
        public ErrorDetails() { }

        public string Code { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> FileExists { get; set; }
    }

    public class FileManagerDirectoryContent
    {
        public FileManagerDirectoryContent() { }

        public FileManagerDirectoryContent[] Data { get; set; }
        public bool ShowHiddenItems { get; set; }
        public string SearchString { get; set; }
        public bool CaseSensitive { get; set; }
        public IList<IFormFile> UploadFiles { get; set; }
        public string[] RenameFiles { get; set; }
        public string TargetPath { get; set; }
        public string ParentId { get; set; }
        public string FilterId { get; set; }
        public string FilterPath { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public bool IsFile { get; set; }
        public bool HasChild { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string PreviousName { get; set; }
        public long Size { get; set; }
        public string Name { get; set; }
        public string[] Names { get; set; }
        public string NewName { get; set; }
        public string Action { get; set; }
        public string Path { get; set; }
        public FileManagerDirectoryContent TargetData { get; set; }
        public AccessPermission Permission { get; set; }
    }

    public class ImageSize
    {
        public ImageSize() { }

        public int Height { get; set; }
        public int Width { get; set; }
    }
}