namespace Dilon.Core
{
    public interface IGeneralCaptcha
    {
        dynamic CheckCode(GeneralCaptchaInput input);

        dynamic CreateCaptchaImage(int length = 4);
    }
}