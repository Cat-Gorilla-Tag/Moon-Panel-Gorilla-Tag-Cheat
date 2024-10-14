using Photon.Pun;
using Steamworks;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static Mono.Math.BigInteger;

namespace StupidTemplate.Menu
{
    internal class Mods
    {
        public static void LongArms()
        {
            GorillaTagger.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        public static void FixArms()
        {
            GorillaTagger.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        public static void MosaBoost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 6.5f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 1.5f;
        }
        public static void HAHAGETSHITONRPCS()
        {
            GorillaNot.instance.rpcErrorMax = int.MaxValue;
            GorillaNot.instance.rpcCallLimit = int.MaxValue;
            GorillaNot.instance.logErrorMax = int.MaxValue;
            PhotonNetwork.MaxResendsBeforeDisconnect = int.MaxValue;
            PhotonNetwork.QuickResends = int.MaxValue;
            PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
            PhotonNetwork.OpCleanRpcBuffer(GorillaTagger.Instance.myVRRig.GetView);
            PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
        }
        public static void AntiReport()
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine l in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    if (l.linePlayer == NetworkSystem.Instance.LocalPlayer)
                    {
                        Transform button = l.reportButton.gameObject.transform;
                        foreach (VRRig player in GorillaParent.instance.vrrigs)
                        {
                            if (player != GorillaTagger.Instance.offlineVRRig)
                            {
                                float rhtorb = Vector3.Distance(player.rightHandTransform.position, button.position);
                                float lhtorb = Vector3.Distance(player.leftHandTransform.position, button.position);

                                if (rhtorb < 0.35f || lhtorb < 0.35f)
                                {
                                        PhotonNetwork.Disconnect();
                                        HAHAGETSHITONRPCS();
                                        NotifiLib.SendNotification("<color=grey>[</color><color=purple>ANTI-REPORT</color><color=grey>]</color> " + Classes.RigManager.GetPlayerFromVRRig(player).NickName + " attempted to report you, you have been disconnected.");
                                }
                            }
                        }
                    }
                }
            }
            catch{}
        }
        public static void Ghost()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GameObject skibadileft = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                GameObject skibadiright = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                skibadiright.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                skibadileft.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                skibadileft.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                skibadiright.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;

                UnityEngine.Object.Destroy(skibadileft.GetComponent<BoxCollider>());
                UnityEngine.Object.Destroy(skibadileft.GetComponent<Collider>());
                UnityEngine.Object.Destroy(skibadileft.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(skibadileft, Time.deltaTime);

                UnityEngine.Object.Destroy(skibadiright.GetComponent<BoxCollider>());
                UnityEngine.Object.Destroy(skibadiright.GetComponent<Collider>());
                UnityEngine.Object.Destroy(skibadiright.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(skibadiright, Time.deltaTime);
                skibadileft.GetComponent<Renderer>().material.color = Color.blue;
                skibadiright.GetComponent<Renderer>().material.color = Color.blue;

            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        public static void Invisible()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(999, 999, 999);
                GameObject skibadileft = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                GameObject skibadiright = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                skibadiright.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                skibadileft.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                skibadileft.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                skibadiright.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;

                UnityEngine.Object.Destroy(skibadileft.GetComponent<BoxCollider>());
                UnityEngine.Object.Destroy(skibadileft.GetComponent<Collider>());
                UnityEngine.Object.Destroy(skibadileft.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(skibadileft, Time.deltaTime);

                UnityEngine.Object.Destroy(skibadiright.GetComponent<BoxCollider>());
                UnityEngine.Object.Destroy(skibadiright.GetComponent<Collider>());
                UnityEngine.Object.Destroy(skibadiright.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(skibadiright, Time.deltaTime);
                skibadileft.GetComponent<Renderer>().material.color = Color.blue;
                skibadiright.GetComponent<Renderer>().material.color = Color.blue;

            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        public static void Fly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 20f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        public static void HandFly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.rightControllerTransform.forward * Time.deltaTime * 20f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        public static void NoClip()
        {
            foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                meshCollider.enabled = !(ControllerInputPoller.instance.rightControllerIndexFloat > 0.2f);
            }
        }
        static GameObject leftplat = null;
        static GameObject rightplat = null;
        public static void Platforms()
        {

            if (ControllerInputPoller.instance.leftGrab)
            {
                if (leftplat == null)
                {
                    leftplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    leftplat.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f) + new Vector3(0f, -0.05f, 0f);
                    leftplat.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    leftplat.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                    leftplat.GetComponent<Renderer>().material.color = UnityEngine.Color.magenta;
                }
            }
            else
            {
                UnityEngine.Object.Destroy(leftplat);
                leftplat = null;
            }
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (rightplat == null)
                {
                    rightplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    rightplat.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f) + new Vector3(0f, -0.05f, 0f);
                    rightplat.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    rightplat.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                    rightplat.GetComponent<Renderer>().material.color = UnityEngine.Color.magenta;
                }
            }
            else
            {
                UnityEngine.Object.Destroy(rightplat);
                rightplat = null;
            }
        }
        public static void TriggerPlatforms()
        {
            if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
            {
                if (leftplat == null)
                {
                    leftplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    leftplat.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f) + new Vector3(0f, -0.05f, 0f);
                    leftplat.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    leftplat.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                    leftplat.GetComponent<Renderer>().material.color = UnityEngine.Color.magenta;
                }
            }
            else
            {
                UnityEngine.Object.Destroy(leftplat);
                leftplat = null;
            }
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
            {
                if (rightplat == null)
                {
                    rightplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    rightplat.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f) + new Vector3(0f, -0.05f, 0f);
                    rightplat.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    rightplat.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                    rightplat.GetComponent<Renderer>().material.color = UnityEngine.Color.magenta;
                }
            }
            else
            {
                UnityEngine.Object.Destroy(rightplat);
                rightplat = null;
            }
        }
        public static void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }
        public static void SpawnRedLucy()
        {
            if (PhotonNetwork.IsMasterClient)
            {
                HalloweenGhostChaser monkesigma = GameObject.Find("Environment Objects/05Maze_PersistentObjects/Halloween2024_PersistentObjects/Halloween Ghosts/Lucy/Halloween Ghost/FloatingChaseSkeleton").GetComponent<HalloweenGhostChaser>();
                monkesigma.timeGongStarted = 0f;
                monkesigma.currentState = HalloweenGhostChaser.ChaseState.Gong;
                monkesigma.isSummoned = true;
            }
        }
        public static void WallWalk()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.Player.Instance.bodyCollider.transform.right * (Time.deltaTime * (3f / Time.deltaTime)), ForceMode.Acceleration);
            }
            if (ControllerInputPoller.instance.leftGrab)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.Player.Instance.bodyCollider.transform.right * (Time.deltaTime * (-3f / Time.deltaTime)), ForceMode.Acceleration);
            }
        }
        public static void FakeOculusMenu()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.leftControllerTransform.position = GorillaTagger.Instance.bodyCollider.transform.position;
                GorillaLocomotion.Player.Instance.leftControllerTransform.rotation = GorillaTagger.Instance.bodyCollider.transform.rotation;
                GorillaLocomotion.Player.Instance.rightControllerTransform.position = GorillaTagger.Instance.bodyCollider.transform.position;
                GorillaLocomotion.Player.Instance.rightControllerTransform.rotation = GorillaTagger.Instance.bodyCollider.transform.rotation;
            }
        }
        public static void CheckIfMaster()
        {
            if (PhotonNetwork.IsMasterClient)
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=green>YES</color><color=grey>]</color> <color=white>You are at the top of the leaderboard so you have access to [M] mods.</color>");
            }
            else
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=red>NO</color><color=grey>]</color> <color=white>You are not at the top of the leaderboard so you do not have access to [M] mods.</color>");
            }
        }
        public static void GrabInGameObject(string asdf, bool righthand)
        {
            if (righthand)
            {
                GameObject.Find(asdf).transform.position = GorillaTagger.Instance.rightHandTransform.position;
            }
            if (!righthand)
            {
                GameObject.Find(asdf).transform.position = GorillaTagger.Instance.leftHandTransform.position;
            }
        }
        public static void GrabBat()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GrabInGameObject("Cave Bat Holdable", true);
            }
            if (ControllerInputPoller.instance.leftGrab)
            {
                GrabInGameObject("Cave Bat Holdable", false);
            }
        }
        public static void GrabBeachBall()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GrabInGameObject("Environment Objects/05Maze_PersistentObjects/WaterPolo/BeachBall", true);
            }
            if (ControllerInputPoller.instance.leftGrab)
            {
                GrabInGameObject("Environment Objects/05Maze_PersistentObjects/WaterPolo/BeachBall", false);
            }
        }
    }
}
