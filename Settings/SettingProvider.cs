using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OdekuTour.Settings
{
    public static class SettingProvider
    {
        private const string _path = "scenes.json";

        public static SettingMessage Serialize(IEnumerable<Scene> scenes)
        {
            SettingMessage message = new SettingMessage("Scenes was successfully deleted!");
            try
            {
                var indented = Formatting.Indented;
                var settings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                var @string = JsonConvert.SerializeObject(scenes, indented, settings);
                using (StreamWriter sw = new StreamWriter(_path, false))
                {
                    sw.Write(@string);
                }
            }
            catch (Exception ex)
            {
                message = new SettingMessage("while updating scenes an error occured!", ex);
            }
            return message;
        }
        public static IEnumerable<Scene> Deserialize()
        {
            using (var fs = new FileStream(_path, FileMode.OpenOrCreate))
            {
                using (var sr = new StreamReader(fs))
                {
                    var settings = new JsonSerializerSettings()
                    {
                        TypeNameHandling = TypeNameHandling.All
                    };
                    var @string = sr.ReadToEnd();
                    var scenes = JsonConvert.DeserializeObject<IEnumerable<Scene>>(@string, settings);
                    return scenes;
                }
            }
        }
    }

    public class SettingMessage
    {
        public string Text { get; set; }
        public Exception Exception { get; set; }
        public bool IsError => Exception != null;

        public SettingMessage() { }
        public SettingMessage(string text)
        {
            Text = text;
        }
        public SettingMessage(Exception exception)
        {
            Exception = exception;
            Text = exception.Message;
        }
        public SettingMessage(string text, Exception exception) : this(text)
        {
            Exception = exception;
        }
    }
}
