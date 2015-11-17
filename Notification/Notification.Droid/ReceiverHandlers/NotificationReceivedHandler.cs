using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CN.Jpush.Android.Api;

namespace Notification.Droid.ReceiverHandlers {
    public class NotificationReceivedHandler : BaseHandler {
        public override string Action {
            get {
                return "cn.jpush.android.intent.NOTIFICATION_RECEIVED";
            }
        }

        public override void Handle(Bundle bundle) {
            //�������������������֪ͨ�ı��⡣
            //��Ӧ API ֪ͨ���ݵ� title �ֶΡ�
            //��Ӧ Portal ����֪ͨ�����ϵġ�֪ͨ���⡱�ֶΡ�
            var title = bundle.GetString(JPushInterface.ExtraNotificationTitle);

            //�������������������֪ͨ���ݡ�
            //��Ӧ API ֪ͨ���ݵ� alert �ֶΡ�
            //��Ӧ Portal ����֪ͨ�����ϵġ�֪ͨ���ݡ��ֶΡ�
            var ctx = bundle.GetString(JPushInterface.ExtraAlert);

            //SDK 1.2.9 ���ϰ汾֧�֡�
            //������������������ĸ����ֶΡ����Ǹ� JSON �ַ�����
            //��Ӧ API ֪ͨ���ݵ� extras �ֶΡ�
            //��Ӧ Portal ������Ϣ�����ϵġ���ѡ���á���ĸ����ֶΡ�
            var extra = bundle.GetString(JPushInterface.ExtraExtra);

            //SDK 1.3.5 ���ϰ汾֧�֡�
            //֪ͨ����Notification ID�������������Notification
            var id = bundle.GetString(JPushInterface.ExtraNotificationId);

            //SDK 1.6.1 ���ϰ汾֧�֡�
            //Ψһ��ʶ֪ͨ��Ϣ�� ID, �������ϱ�ͳ�Ƶȡ�
            var msgID = bundle.GetString(JPushInterface.ExtraMsgId);

            //��������������������������͡�
            //��Ӧ API ��Ϣ���ݵ� content_type �ֶΡ�
            //Portal ����ʱδ�ṩ�����ֶΡ�
            var contentType = bundle.GetString(JPushInterface.ExtraContentType);

            //SDK 1.4.0 ���ϰ汾֧�֡�
            //��ý��֪ͨ�������ص�HTML���ļ�·��,����չ��WebView��            
            var richHtmlPath = bundle.GetString(JPushInterface.ExtraRichpushHtmlPath);

            //SDK 1.4.0 ���ϰ汾֧�֡�
            //��ý��֪ͨ�������ص�ͼƬ��Դ���ļ���,����ļ����� ������ �ֿ��� �� ��JPushInterface.EXTRA_RICHPUSH_HTML_PATH�� λ��ͬһ��·����
            var richHtmlRes = bundle.GetString(JPushInterface.ExtraRichpushHtmlRes);
        }
    }
}