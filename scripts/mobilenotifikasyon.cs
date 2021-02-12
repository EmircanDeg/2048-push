using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class mobilenotifikasyon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AndroidNotificationCenter.CancelAllDisplayedNotifications();

        //notifikyon için kanal yarattık
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "notifications Channel",
            Importance = Importance.Default,
            Description = "reminder notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        //gidecek mesaj
        var notification = new AndroidNotification();
        notification.Title = "PUSH 2048";
        notification.Text = "Play now!";
        notification.SmallIcon = "smallicon";
        notification.LargeIcon = "largeicon";
        notification.FireTime = System.DateTime.Now.AddHours(24);

        //mesaj ve  gideceği kanal
        var id =AndroidNotificationCenter.SendNotification(notification, "channel_id");

        //tekrar tekrar gitmesini engelleme
        if(AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled) 
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
