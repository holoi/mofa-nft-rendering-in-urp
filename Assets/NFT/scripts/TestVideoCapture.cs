using UnityEditor.Recorder;
using UnityEditor.Recorder.Input;
using UnityEditor.Recorder.Encoder;
using UnityEngine;
using System.Collections;

public class TestVideoCapture : MonoBehaviour
{
    int _index = 0;
    [SerializeField] bool _startRcord = false;

    //
    RecorderControllerSettings _controllerSettings;
    RecorderController _recorderController;
    MovieRecorderSettings _moiveRecorderSettings;

    // This function gets called when entering Play Mode. We configure the Recorder and start it.
    private void OnEnable()
    {
        CreateRecorder();

    }
    private void Update()
    {
        if (_startRcord)
        {
            _index++;
            _startRcord = false;
            StartRecord();
        }
    }

    void CreateRecorder()
    {
         _controllerSettings = ScriptableObject.CreateInstance<RecorderControllerSettings>();
         _recorderController = new RecorderController(_controllerSettings);
         _moiveRecorderSettings = ScriptableObject.CreateInstance<MovieRecorderSettings>();
        var videoRecorderSettings = new CoreEncoderSettings();
        videoRecorderSettings.EncodingQuality = CoreEncoderSettings.VideoEncodingQuality.High;

        _moiveRecorderSettings.name = "My Video Recorder";
        _moiveRecorderSettings.Enabled = true;
        _moiveRecorderSettings.EncoderSettings = videoRecorderSettings;

        _moiveRecorderSettings.ImageInputSettings = new GameViewInputSettings
        {
            OutputWidth = 256,
            OutputHeight = 256
        };

        _moiveRecorderSettings.AudioInputSettings.PreserveAudio = true;

        _controllerSettings.AddRecorderSettings(_moiveRecorderSettings);
        _controllerSettings.SetRecordModeToFrameInterval(0, 59); // 2s @ 30 FPS
        _controllerSettings.FrameRate = 30;

        RecorderOptions.VerboseMode = false;

    }

    void StartRecord()
    {
        _moiveRecorderSettings.OutputFile = Application.dataPath + "/../RecordingTests/movie-"+_index;
        _recorderController.PrepareRecording();
        _recorderController.StartRecording();
    }

    void ResetScene()
    {

    }

    IEnumerator WaitRecorderReady()
    {
        yield return new WaitForSeconds(3);
    }
}