using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using static CitizenFX.Core.Native.API;

namespace Policehandbook
{
    public class Policehandbook : BaseScript
    {

        [Command("arrest")]
        private void CommandHandler()
        {
            Screen.ShowNotification($"~r~Arrest~s~:\n\nThe time now is ___\n\nYou are currently under arrest on suspision of ___.\n\nYou do not have to say anything. But, it may harm your defence if you do not mention when questioned something which you later rely on in court. Anything you do say may be given in evidence.\n\nDo you understand?.\n\nThe necessities for your arrest are to ___.");
        }

        [Command("book")]
        private void CommandHandler2()
        {
            Screen.ShowNotification($"~r~Booking Cell Space~s~:\n\nFormat:\n~b~Custody Suite:~s~ ___\n~b~Age:~s~ ADULT/CHILD\n~b~Sex:~s~ MALE/FEMALE\n~b~Behaviour:~s~ COMPLIANT/NON-COMPLIANT\n~b~Arrested by:~s~ OFFICER\n~b~Offence:~s~___");
        }

        [Command("gowisely")]
        private void CommandHandler3()
        {
            Screen.ShowNotification("~r~GOWISELY - Search~s~:\n\n~b~Grounds:~s~ for the search\n~b~Object:~s~ of the search\n~b~Warrant card:~s~ If not in uniform\n~b~Identity:~s~ I am PC ___\n~b~Station:~s~ attached to ___ Police Station\n~b~Entitlement:~s~ Entitled to a copy of this search up to ___ months.\n~b~Legal power:~s~ Searching under s1 PACE (1984) / s23 MODA (1971)\n~b~You:~s~ You are currently detained for the purpose of a search.");
        }

        [Command("methane")]
        private void CommandHandler4()
        {
            Screen.ShowNotification("~r~METHANE - Major Incident~s~:\n\n~b~Major Incident Declared:~s~ __\n~b~Exact Location:~s~ of incident\n~b~Type of incident:~s~ category\n~b~Hazards:~s~ in the area\n~b~Access:~s~ routes in/out\n~b~Number and types of casualties:~s~ ___\n~b~Emergency Services present and required:~s~ ___.");
        }

        [Command("ic")]
        private void CommandHandler5()
        {
            Screen.ShowNotification("~r~IC - Identity Codes~s~:\n\n~b~IC1:~s~ White - North European\n~b~IC2:~s~ White - South European\n~b~IC3:~s~ Black\n~b~IC4:~s~ Asian\n~b~IC5:~s~ Chinese, Japanese or other South East Asian\n~b~IC6:~s~ Arabic or North African\n~b~IC9:~s~ Unknown");
        }

        [Command("nec")]
        private void CommandHandler6()
        {
            Screen.ShowNotification("~r~Arrest Necessities - (IDCOPPLAN)~s~:\n\n~b~Investigation:~s~ conduct a prompt and effective.\n~b~Disappearance:~s~ prevent the prosecution being hindered.\n~b~Child or Vulnerable person:~s~ to protect a.\n~b~Obstruction:~s~ of the highway unlawfully (preventing).\n~b~Physical Injury:~s~ prevent to themselves or other person.\n~b~Public Decency:~s~ prevent an offence being committed against.\n~b~Loss or Damage:~s~ prevent to property.\n~b~Address:~s~ enable to be ascertained (not readily available).\n~b~Name:~s~ enable to be ascertained (not readily available).");
        }

        [Command("ipp")]
        private void CommandHandler7()
        {
            Screen.ShowNotification("~r~Initial Phase Pursuit - (IPP)~s~:\n\n~b~VEHICLE DESCRIPTION:~s~ MAKE/MODEL/VRM\n~b~LOCATION & DIRECTION:~s~ ___\n~b~SPEED:~s~\n___\n\n~b~VEHICLE DENSITY:~s~ LOW/MED/HIGH\n~b~PEDESTRIAN DENSITY:~s~ LOW/MED/HIGH\n~b~ROAD CONDITIONS:~s~ WET/DRY/DIRT\n~b~WEATHER:~s~ CLEAR/LIGHT/DARK\n~b~VISIBILITY:~s~\nCLEAR/MED/LOW\n\n~b~DRIVER CLASSIFICATION:~s~ IPP/ADV/TPAC\n~b~POLICE VEHICLE:~s~ MARKED/UNMARKED");
        }

        [Command("tor")]
        private void CommandHandler8()
        {
            Screen.ShowNotification("~r~Traffic Offence Report - (TOR)~s~:\n\nI am reporting you for consideration of the question of prosecuting you for the offence(s) of ___.\n\nYou do not have to say anything but it may harm your defence if you do not mention NOW something which you may later rely on in court. Anything you do say may be given in evidence.\n\nYou are not under arrest - you are entitled to legal advice and you are not obliged to remain with me.");
        }

        [Command("wm")]
        private void CommandHandler9()
        {
            Screen.ShowNotification("~r~Warning Markers - (WM)~s~:\n\n~b~FI:~s~ FIREARMS\n~b~WE:~s~ WEAPONS\n~b~XP:~s~ EXPLOSIVES\n~b~VI:~s~ VIOLENT\n~b~CO:~s~ CONTAGIOUS\n~b~ES:~s~ ESCAPER\n~b~AG:~s~ ALLEGES\n~b~AT:~s~ AILMENT\n~b~SU:~s~ SUICIDAL\n~b~MH:~s~ MENTAL HEALTH\n~b~DR:~s~ DRUGS\n~b~IM:~s~ MALE IMPERSONATOR\n~b~IF:~s~ FEMALE IMPERSONATOR");
        }

        [Command("136")]
        private void CommandHandler10()
        {
            Screen.ShowNotification("~r~s136 Mental Health Act 1983 - Overview~s~:\n\nA constable may take a person to (or keep at) a ~b~place of a safety.~s~ This can be done without a warrant if:\n\nThe individual appears to have a mental disorder, and\n\nThey are in any place other than a house, flat or room where a person is living, or garden or garage that only one household has access to, and\n\nThey are in need of immediate care or control.\n\nA registered medical practitioner/healthcare professional must be consulted if practicable to do so.");
        }

        [Command("handbook")]
        private void CommandHandler11()
        {
            Screen.ShowNotification("~r~Police Handbook - Commands~s~:\n\n~b~/arrest~s~ - Arrest Format\n~b~/nec~s~ - Arrest Necessities\n~b~/gowisely~s~ - Stop and Search\n~b~/ipp~s~ - Initial Phase Pursuit\n~b~/tor~s~ - Traffic Offence Report\n~b~/ic~s~ - Identity Codes\n~b~/wm~s~ - Warning Markers\n~b~/methane~s~ - Major Incident\n~b~/136~s~ - Mental Health Act\n~b~/book~s~ - Book Cell Space");

        }

        /* Police Handbook - © 2020 London Studios - Do not redistibute, modify/change or reupload without my obtained permission. 
         * This may be used on public/private FiveM servers and used in videos published to websites, 
         * however the source files should not be redistributed. This is for non-commercial use. */
    }
}
