using UnityEditor.Recorder;
using UnityEditor.Recorder.Input;
using UnityEditor.Recorder.Encoder;
using UnityEngine;
using System.Collections;

public class TestVideoCapture : MonoBehaviour
{
    int _index = 0;
    bool _startRcord = false;

    //
    RecorderControllerSettings controllerSettings;
    RecorderController TestRecorderController;

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
            StartRecordVideo();
        }
    }

    void CreateRecorder()
    {
         controllerSettings = ScriptableObject.CreateInstance<RecorderControllerSettings>();
         TestRecorderController = new RecorderController(controllerSettings);
        var videoRecorder = ScriptableObject.CreateInstance<MovieRecorderSettings>();
        var videoRecorderSettings = new CoreEncoderSettings();
        videoRecorderSettings.EncodingQuality = CoreEncoderSettings.VideoEncodingQuality.High;

        videoRecorder.name = "My Video Recorder";
        videoRecorder.Enabled = true;
        videoRecorder.EncoderSettings = videoRecorderSettings;

        videoRecorder.ImageInputSettings = new GameViewInputSettings
        {
            OutputWidth = 256,
            OutputHeight = 256
        };

        videoRecorder.AudioInputSettings.PreserveAudio = true;
        videoRecorder.OutputFile = "C: \\Users\\18861\\Documents\\Unity Repo\\MagicsInsideVectorField\\Recordings";
        

        controllerSettings.AddRecorderSettings(videoRecorder);
        controllerSettings.SetRecordModeToFrameInterval(0, 59); // 2s @ 30 FPS
        controllerSettings.FrameRate = 30;

        RecorderOptions.VerboseMode = false;
    }

    void StartRecordVideo()
    {
        TestRecorderController.PrepareRecording();
        TestRecorderController.StartRecording();

        // Wait a while
    }

    IEnumerator WaitRecorderReady()
    {
        yield return new WaitForSeconds(3);
    }
}