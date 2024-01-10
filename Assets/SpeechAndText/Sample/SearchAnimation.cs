using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SearchAnimation : MonoBehaviour
{
    private Animator anim;
    public InputField inputText;

    public Text messageText;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Start");

        StartCoroutine(CheckAndReturnToStart());

        messageText.gameObject.SetActive(false);


    }


    IEnumerator CheckAndReturnToStart()
    {
        while (true)
        {

            Debug.Log(inputText.text);

            //1greetings
            if (inputText.text == "สวัสดี" || inputText.text == "สวัสดีครับ" || inputText.text == "สวัสดีค่ะ" ||  inputText.text == "สวัสดีจ้า")
            {
                anim.SetTrigger("Hello");
                
            }
            else if (inputText.text == "ขอบคุณ" || inputText.text == "ขอบคุณครับ" || inputText.text == "ขอบคุณค่ะ" ||  inputText.text == "ขอบคุณจ้า")
            {
                anim.SetTrigger("ThankYou");

            }
            else if (inputText.text == "ขอโทษ" || inputText.text == "ขอโทษครับ" || inputText.text == "ขอโทษค่ะ" ||  inputText.text == "ขอโทษจ้า")
            { 
                anim.SetTrigger("Sorry");

            }
            else if (inputText.text == "ไม่สบายใจ" || inputText.text == "ไม่สบายใจครับ" || inputText.text == "ไม่สบายใจค่ะ" )
            { 
                anim.SetTrigger("์NotHappy");

            }
            else if (inputText.text == "ไม่สบาย" || inputText.text == "ไม่สบายครับ" || inputText.text == "ไม่สบายค่ะ" || inputText.text == "ป่วย")
            { 
                anim.SetTrigger("Sick");

            }
            else if (inputText.text == "ใช่" || inputText.text == "ถูกต้อง" || inputText.text == "ใช่แล้ว" || inputText.text == "ใช่เลย")
            { 
                anim.SetTrigger("Yes");

            }
            else if (inputText.text == "ไม่ใช่" || inputText.text == "ไม่ใช่นะ" || inputText.text == "ไม่ถูก" || inputText.text == "ไม่ถูกต้อง" || inputText.text == "ไม่ได้")
            { 
                anim.SetTrigger("No");

            }
            else if (inputText.text == "พบกันใหม่")
            { 
                anim.SetTrigger("SeeYouAgain");

            }
            else if (inputText.text == "โชคดี")
            { 
                anim.SetTrigger("GoodLuck");

            }
            else if (inputText.text == "ไม่เป็นไร")
            { 
                anim.SetTrigger("YoureWelcome");

            }

            //2Number
            else if (inputText.text == "หนึ่ง")
            { 
                anim.SetTrigger("One");

            }
            else if (inputText.text == "สอง")
            { 
                anim.SetTrigger("Two");

            }
            else if (inputText.text == "สาม")
            { 
                anim.SetTrigger("Three");

            }
            else if (inputText.text == "สี่")
            { 
                anim.SetTrigger("Four");

            }
            else if (inputText.text == "ห้า")
            { 
                anim.SetTrigger("Five");

            }
            else if (inputText.text == "หก")
            { 
                anim.SetTrigger("Six");

            }
            else if (inputText.text == "เจ็ด")
            { 
                anim.SetTrigger("Seven");

            }
            else if (inputText.text == "แปด")
            { 
                anim.SetTrigger("Eight");

            }
            else if (inputText.text == "เก้า")
            { 
                anim.SetTrigger("Nine");

            }
            else if (inputText.text == "สิบ")
            { 
                anim.SetTrigger("Ten");

            }
            else if (inputText.text == "สิบเอ็ด")
            { 
                anim.SetTrigger("Eleven");

            }
            else if (inputText.text == "สิบสอง")
            { 
                anim.SetTrigger("Twelve");

            }

            else if (inputText.text == "สิบสาม")
            { 
                anim.SetTrigger("Thirteen");

            }
            else if (inputText.text == "สิบสี่")
            { 
                anim.SetTrigger("Fourteen");

            }
            else if (inputText.text == "สิบห้า")
            { 
                anim.SetTrigger("Fifteen");

            }
            else if (inputText.text == "สิบหก")
            { 
                anim.SetTrigger("Sixteen");

            }
            else if (inputText.text == "สิบเจ็ด")
            { 
                anim.SetTrigger("Seventeen");

            }
            else if (inputText.text == "สิบแปด")
            { 
                anim.SetTrigger("Eighteen");

            }
            else if (inputText.text == "สิบเก้า")
            { 
                anim.SetTrigger("Nineteen");

            }
            else if (inputText.text == "ยี่สิบ")
            { 
                anim.SetTrigger("Twenty");

            }
            else if (inputText.text == "สามสิบ")
            { 
                anim.SetTrigger("Thirty");

            }
            else if (inputText.text == "สี่สิบ")
            { 
                anim.SetTrigger("Forty");

            }
            else if (inputText.text == "ห้าสิบ")
            { 
                anim.SetTrigger("Fifty");

            }
            else if (inputText.text == "หกสิบ")
            { 
                anim.SetTrigger("Sixty");

            }
            else if (inputText.text == "เจ็ดสิบ")
            { 
                anim.SetTrigger("Seventy");

            }
            else if (inputText.text == "แปดสิบ")
            { 
                anim.SetTrigger("Eighty");

            }
            else if (inputText.text == "เก้าสิบ")
            { 
                anim.SetTrigger("Ninety");

            }

            else if (inputText.text == "หนึ่งร้อย")
            { 
                anim.SetTrigger("Hundred");

            }
            else if (inputText.text == "หนึ่งพัน")
            { 
                anim.SetTrigger("Thousand");

            }
            else if (inputText.text == "หนึ่งหมื่น")
            { 
                anim.SetTrigger("TenThousand");

            }
            else if (inputText.text == "หนึ่งแสน")
            { 
                anim.SetTrigger("HundredThousand");

            }
            else if (inputText.text == "หนึ่งล้าน")
            { 
                anim.SetTrigger("Million");

            }


            //time
            else if (inputText.text == "เวลา")
            { 
                anim.SetTrigger("Time");

            }
            else if (inputText.text == "บ่าย")
            { 
                anim.SetTrigger("Afternoon");

            }
            else if (inputText.text == "เย็น")
            { 
                anim.SetTrigger("Evening");

            }
            else if (inputText.text == "เช้า")
            { 
                anim.SetTrigger("Morning");

            }
            else if (inputText.text == "กลางวัน" || inputText.text == "เที่ยงวัน")
            { 
                anim.SetTrigger("Midday");

            }
            else if (inputText.text == "ค่ำ")
            { 
                anim.SetTrigger("Dusk");

            }
            else if (inputText.text == "กลางคืน" || inputText.text == "มืด")
            { 
                anim.SetTrigger("Midnight");

            }
            else if (inputText.text == "24 ชั่วโมง" || inputText.text == "ตลอด 24 ชั่วโมง")
            { 
                anim.SetTrigger("24Hours");

            }

            //4date
            else if (inputText.text == "วัน")
            { 
                anim.SetTrigger("Day");

            }
            else if (inputText.text == "สัปดาห์")
            { 
                anim.SetTrigger("Week");

            }
            else if (inputText.text == "นี้" || inputText.text == "วันนี้" || inputText.text == "ขณะนี้")
            { 
                anim.SetTrigger("Today");

            }
            else if (inputText.text == "พรุ่งนี้")
            { 
                anim.SetTrigger("Tomorrow");

            }
            else if (inputText.text == "มะรืนนี้")
            { 
                anim.SetTrigger("Tonight");

            }
            else if (inputText.text == "เมื่อวานนี้" || inputText.text == "เมื่อวาน")
            { 
                anim.SetTrigger("Yesterday");

            }
            else if (inputText.text == "เมื่อวานซืน")
            { 
                anim.SetTrigger("DayBeforeYesterday");

            }
            else if (inputText.text == "เดือน")
            { 
                anim.SetTrigger("Month");

            }
            else if (inputText.text == "ปี")
            { 
                anim.SetTrigger("Year");

            }
            else if (inputText.text == "อายุ")
            { 
                anim.SetTrigger("Age");

            }


            //5Question
            else if (inputText.text == "อะไร")
            { 
                anim.SetTrigger("What");

            }
            else if (inputText.text == "ใคร")
            { 
                anim.SetTrigger("Who");

            }
            else if (inputText.text == "ทำไม")
            { 
                anim.SetTrigger("Why");

            }
            else if (inputText.text == "ไหน" || inputText.text == "ที่ไหน")
            { 
                anim.SetTrigger("Where");

            }
            else if (inputText.text == "เท่าไหร่")
            { 
                anim.SetTrigger("HowMuch");

            }
            else if (inputText.text == "อย่างไร")
            { 
                anim.SetTrigger("How");

            }
            else if (inputText.text == "อีกเมื่อไหร่")
            { 
                anim.SetTrigger("WhenNext");

            }
            else if (inputText.text == "เมื่อไหร่")
            { 
                anim.SetTrigger("When");

            }

            //6family
            else if (inputText.text == "ผู้ใหญ่")
            { 
                anim.SetTrigger("Adult");

            }
            else if (inputText.text == "ผู้ชาย")
            { 
                anim.SetTrigger("Male");

            }
            else if (inputText.text == "ผู้หญิง")
            { 
                anim.SetTrigger("Female");

            }
            else if (inputText.text == "เด็ก")
            { 
                anim.SetTrigger("Child");

            }
            else if (inputText.text == "เด็กทารก")
            { 
                anim.SetTrigger("Infant");

            }
            else if (inputText.text == "วัยรุ่น" || inputText.text == "เยาวชน")
            { 
                anim.SetTrigger("Teenager");

            }
            else if (inputText.text == "หนุ่ม" || inputText.text == "สาว" || inputText.text == "หนุ่มสาว")
            { 
                anim.SetTrigger("BoyGirl");

            }
            else if (inputText.text == "ชรา" || inputText.text == "คนชรา" || inputText.text == "คนแก่" || inputText.text == "แก่")
            { 
                anim.SetTrigger("Elderly");

            }
            else if (inputText.text == "ฉัน" || inputText.text == "ดิฉัน" || inputText.text == "ผม" || inputText.text == "กระผม")
            { 
                anim.SetTrigger("I");

            }
            else if (inputText.text == "คุณ" || inputText.text == "เธอ" || inputText.text == "นาย")
            { 
                anim.SetTrigger("You");

            }
            else if (inputText.text == "เขา")
            { 
                anim.SetTrigger("HeShe");

            }
            else if (inputText.text == "พวกเรา")
            { 
                anim.SetTrigger("We");

            }
            else if (inputText.text == "พวกเขา")
            { 
                anim.SetTrigger("They");

            }


            //7relation
            else if (inputText.text == "ญาติ")
            { 
                anim.SetTrigger("Relative");

            }
            else if (inputText.text == "ตา")
            { 
                anim.SetTrigger("Grandfather");

            }
            else if (inputText.text == "ยาย")
            { 
                anim.SetTrigger("Grandmother");

            }
            else if (inputText.text == "ปู่")
            { 
                anim.SetTrigger("PaternalGrandfather");

            }
            else if (inputText.text == "ย่า")
            { 
                anim.SetTrigger("PaternalGrandmother");

            }
            else if (inputText.text == "ลุง")
            { 
                anim.SetTrigger("Uncle");

            }
            else if (inputText.text == "ป้า")
            { 
                anim.SetTrigger("Aunt");

            }
            else if (inputText.text == "น้า")
            { 
                anim.SetTrigger("MaternalUncle");

            }
            else if (inputText.text == "อา")
            { 
                anim.SetTrigger("MaternalAunt");

            }
            else if (inputText.text == "หลาน")
            { 
                anim.SetTrigger("NieceNephew");

            }
            else if (inputText.text == "เพื่อน")
            { 
                anim.SetTrigger("Friend");

            }
            else if (inputText.text == "แฟน")
            { 
                anim.SetTrigger("Partner");

            }
            else if (inputText.text == "แต่งงาน" || inputText.text == "สมรส")
            { 
                anim.SetTrigger("Married");

            }
            else if (inputText.text == "โสด")
            { 
                anim.SetTrigger("Single");

            }
            else if (inputText.text == "หย่า")
            { 
                anim.SetTrigger("Divorced");

            }


            //8colour
            else if (inputText.text == "สี")
            { 
                anim.SetTrigger("Color");

            }
            else if (inputText.text == "สีแดง")
            { 
                anim.SetTrigger("Red");

            }
            else if (inputText.text == "สีดำ")
            { 
                anim.SetTrigger("Black");

            }
            else if (inputText.text == "สีขาว")
            { 
                anim.SetTrigger("White");

            }
            else if (inputText.text == "สีน้ำตาล")
            { 
                anim.SetTrigger("Brown");

            }
            else if (inputText.text == "สีส้ม")
            { 
                anim.SetTrigger("Orange");

            }
            else if (inputText.text == "สีเทา")
            { 
                anim.SetTrigger("Gray");

            }
            else if (inputText.text == "สีกากี")
            { 
                anim.SetTrigger("Khaki");

            }
            else if (inputText.text == "สีเหลือง")
            { 
                anim.SetTrigger("Yellow");

            }
            else if (inputText.text == "สีฟ้า")
            { 
                anim.SetTrigger("Blue");

            }
            else if (inputText.text == "สีชมพู")
            { 
                anim.SetTrigger("Pink");

            }
            else if (inputText.text == "สีเขียว")
            { 
                anim.SetTrigger("Green");

            }
            else if (inputText.text == "สีน้ำเงิน")
            { 
                anim.SetTrigger("Blue");

            }
            else if (inputText.text == "สีม่วง")
            { 
                anim.SetTrigger("Purple");

            }
            else if (inputText.text == "สีทอง")
            { 
                anim.SetTrigger("Gold");

            }
            else if (inputText.text == "สีเงิน")
            { 
                anim.SetTrigger("Silver");

            }
            else if (inputText.text == "สีครีม")
            { 
                anim.SetTrigger("Cream");

            }
            else if (inputText.text == "สีอ่อน")
            { 
                anim.SetTrigger("LightColor");

            }
            else if (inputText.text == "สีเข้ม")
            { 
                anim.SetTrigger("DarkColor");

            }

            
            //9taste
            else if (inputText.text == "หวาน")
            { 
                anim.SetTrigger("Sweet");

            }
            else if (inputText.text == "ธรรมดา")
            { 
                anim.SetTrigger("Normal");

            }
            else if (inputText.text == "อร่อย")
            { 
                anim.SetTrigger("Delicious");

            }
            else if (inputText.text == "ไม่อร่อย" || inputText.text == "ไม่มีรสชาติ")
            { 
                anim.SetTrigger("NotTasty");

            }
            else if (inputText.text == "ขม")
            { 
                anim.SetTrigger("Bitter");

            }
            else if (inputText.text == "เปรี้ยว")
            { 
                anim.SetTrigger("Sour");

            }
            else if (inputText.text == "จืด")
            { 
                anim.SetTrigger("Plain");

            }else if (inputText.text == "เค็ม")
            { 
                anim.SetTrigger("Salty");

            }
            else if (inputText.text == "เผ็ด")
            { 
                anim.SetTrigger("Spicy");

            }


            //10animal
            else if (inputText.text == "สัตว์")
            { 
                anim.SetTrigger("Animal");

            }else if (inputText.text == "สุนัข" || inputText.text == "หมา")
            { 
                anim.SetTrigger("Dog");

            }
            else if (inputText.text == "แมว")
            { 
                anim.SetTrigger("Cat");

            }
            else if (inputText.text == "หมู")
            { 
                anim.SetTrigger("Pig");

            }
            else if (inputText.text == "ไก่")
            { 
                anim.SetTrigger("Chicken");

            }
            else if (inputText.text == "งู")
            { 
                anim.SetTrigger("Snake");

            }
            else if (inputText.text == "แมลงสาบ")
            { 
                anim.SetTrigger("Dragonfly");

            }
            else if (inputText.text == "กุ้ง")
            { 
                anim.SetTrigger("Shrimp");

            }
            else if (inputText.text == "ปลา")
            { 
                anim.SetTrigger("Fish");

            }
            else if (inputText.text == "หอย")
            { 
                anim.SetTrigger("Shellfish");

            }
                    

            //11body
            else if (inputText.text == "ร่างกาย")
            { 
                anim.SetTrigger("Body");

            }
            else if (inputText.text == "ศีรษะ" || inputText.text == "หัว")
            { 
                anim.SetTrigger("Head");

            }
            else if (inputText.text == "ผม")
            { 
                anim.SetTrigger("Hair");

            }
            else if (inputText.text == "หน้า")
            { 
                anim.SetTrigger("Face");

            }
            else if (inputText.text == "ตา")
            { 
                anim.SetTrigger("Eyes");

            }
            else if (inputText.text == "ขนตา")
            { 
                anim.SetTrigger("Eyelashes");

            }
            else if (inputText.text == "คิ้ว")
            { 
                anim.SetTrigger("Eyebrows");

            }
            else if (inputText.text == "จมูก")
            { 
                anim.SetTrigger("Nose");

            }
            else if (inputText.text == "ปาก")
            { 
                anim.SetTrigger("Mouth");

            }
            else if (inputText.text == "ฟัน")
            { 
                anim.SetTrigger("Teeth");

            }
            else if (inputText.text == "ลิ้น")
            { 
                anim.SetTrigger("Tongue");

            }
            else if (inputText.text == "คาง")
            { 
                anim.SetTrigger("Chin");

            }
            else if (inputText.text == "หู")
            { 
                anim.SetTrigger("Ears");

            }
            else if (inputText.text == "แก้ม")
            { 
                anim.SetTrigger("Cheeks");

            }
            else if (inputText.text == "คอ")
            { 
                anim.SetTrigger("Neck");

            }
            else if (inputText.text == "ลูกกระเดือก")
            { 
                anim.SetTrigger("AdamApple");

            }
            else if (inputText.text == "ไหล่")
            { 
                anim.SetTrigger("Shoulders");

            }
            else if (inputText.text == "แขน")
            { 
                anim.SetTrigger("Arms");

            }
            else if (inputText.text == "ข้อศอก")
            { 
                anim.SetTrigger("Elbows");

            }
            else if (inputText.text == "มือ")
            { 
                anim.SetTrigger("Hands");

            }
            else if (inputText.text == "นิ้วมือ")
            { 
                anim.SetTrigger("Fingers");

            }
            else if (inputText.text == "เล็บมือ")
            { 
                anim.SetTrigger("Fingernails");

            }
            else if (inputText.text == "หน้าอก")
            { 
                anim.SetTrigger("Chest");

            }
            else if (inputText.text == "ท้อง")
            { 
                anim.SetTrigger("Stomach");

            }
            else if (inputText.text == "สะดือ")
            { 
                anim.SetTrigger("Navel");

            }
            else if (inputText.text == "หลัง")
            { 
                anim.SetTrigger("Back");

            }
            else if (inputText.text == "เอว")
            { 
                anim.SetTrigger("Waist");

            }
            else if (inputText.text == "สะโพก")
            { 
                anim.SetTrigger("Hips");

            }
            else if (inputText.text == "ก้น")
            { 
                anim.SetTrigger("Buttocks");

            }
            else if (inputText.text == "ลูกอัณฑะ")
            { 
                anim.SetTrigger("Groin");

            }
            else if (inputText.text == "ขา")
            { 
                anim.SetTrigger("Legs");

            }
            else if (inputText.text == "หัวเข่า")
            { 
                anim.SetTrigger("Knees");

            }
            else if (inputText.text == "เท้า")
            { 
                anim.SetTrigger("Feet");

            }


            //เครื่องใน
            else if (inputText.text == "สมอง")
            { 
                anim.SetTrigger("Brain");

            }
            else if (inputText.text == "หัวใจ")
            { 
                anim.SetTrigger("Heart");

            }
            else if (inputText.text == "ปอด")
            { 
                anim.SetTrigger("Lungs");

            }
            else if (inputText.text == "หลอดลม")
            { 
                anim.SetTrigger("Bronchi");

            }
            else if (inputText.text == "ตับ")
            { 
                anim.SetTrigger("Liver");

            }
            else if (inputText.text == "ไต")
            { 
                anim.SetTrigger("Kidney");

            }
            else if (inputText.text == "กระเพาะอาหาร")
            { 
                anim.SetTrigger("StomachA");

            }
            else if (inputText.text == "ลำไส้เล็ก")
            { 
                anim.SetTrigger("SmallIntestine");

            }
            else if (inputText.text == "ลำไส้ใหญ่")
            { 
                anim.SetTrigger("LargeIntestine");

            }
            else if (inputText.text == "ไส้ติ่ง")
            { 
                anim.SetTrigger("Appendix");

            }
            else if (inputText.text == "เลือด")
            { 
                anim.SetTrigger("Blood");

            }
            else if (inputText.text == "กระเพาะปัสสาวะ")
            { 
                anim.SetTrigger("Bladder");

            }
            else if (inputText.text == "รังไข่")
            { 
                anim.SetTrigger("Ovaries");

            }
            else if (inputText.text == "มดลูก")
            { 
                anim.SetTrigger("Uterus");

            }
            else if (inputText.text == "ประจำเดือน")
            { 
                anim.SetTrigger("Menstruation");

            }
            else if (inputText.text == "ระดูขาว")
            { 
                anim.SetTrigger("WhiteDischarge");

            }
            

            //12dress
            else if (inputText.text == "เสื้อแขนสั้น")
            { 
                anim.SetTrigger("ShortSleeveShirt");

            }
            else if (inputText.text == "เสื้อแขนยาว")
            { 
                anim.SetTrigger("LongSleeveShirt");

            }
            else if (inputText.text == "เสื้อยืด")
            { 
                anim.SetTrigger("TShirt");

            }
            else if (inputText.text == "เสื้้อกล้าม")
            { 
                anim.SetTrigger("TankTop");

            }
            else if (inputText.text == "เสื้อเชิ้ต")
            { 
                anim.SetTrigger("DressShirt");

            }
            else if (inputText.text == "เสื้อกันหนาว")
            { 
                anim.SetTrigger("WinterCoat");

            }
            else if (inputText.text == "เสื้อชั้นใน" || inputText.text == "ยกทรง")
            { 
                anim.SetTrigger("Undershirt");

            }
            else if (inputText.text == "กระโปรง")
            { 
                anim.SetTrigger("Skirt");

            }
            else if (inputText.text == "กางเกงขาสั้น")
            { 
                anim.SetTrigger("Shorts");

            }
            else if (inputText.text == "กางเกงขายาว")
            { 
                anim.SetTrigger("Pants");

            }
            else if (inputText.text == "กางเกงยีนส์")
            { 
                anim.SetTrigger("Jeans");

            }
            else if (inputText.text == "กางเกงชั้นในผู้ชาย" || inputText.text == "กางเกงในผู้ชาย")
            { 
                anim.SetTrigger("MenUnderwear");

            }
            else if (inputText.text == "กางเกงชั้นในผู้หญิง" || inputText.text == "กางเกงในผู้หญิง")
            { 
                anim.SetTrigger("WomenUnderwear");

            }
            else if (inputText.text == "ผ้าเช็ดหน้า")
            { 
                anim.SetTrigger("FaceTowel");

            }
            else if (inputText.text == "ผ้าเช็ดตัว")
            { 
                anim.SetTrigger("BathTowel");

            }
            else if (inputText.text == "ผ้าถุง")
            { 
                anim.SetTrigger("Handkerchief");

            }
            else if (inputText.text == "หมวกผู้ชาย")
            { 
                anim.SetTrigger("MenHat");

            }
            else if (inputText.text == "หมวกผู้หญิง")
            { 
                anim.SetTrigger("WomenHat");

            }
            else if (inputText.text == "เนคไท")
            { 
                anim.SetTrigger("Necktie");

            }
            else if (inputText.text == "เข็มขัด")
            { 
                anim.SetTrigger("Belt");

            }
            else if (inputText.text == "ถุงมือ")
            { 
                anim.SetTrigger("Gloves");

            }
            else if (inputText.text == "ถุงเท้า")
            { 
                anim.SetTrigger("Socks");

            }
            else if (inputText.text == "รองเท้า")
            { 
                anim.SetTrigger("Shoes");

            }


            //13feeling
            else if (inputText.text == "ความรู้สึก" || inputText.text == "อาการ")
            { 
                anim.SetTrigger("Emotion");

            }
            else if (inputText.text == "ระบายความในใจ")
            { 
                anim.SetTrigger("ExpressFeelings");

            }
            else if (inputText.text == "รัก")
            { 
                anim.SetTrigger("Love");

            }
            else if (inputText.text == "เกลียด")
            { 
                anim.SetTrigger("Hate");

            }
            else if (inputText.text == "ชอบ")
            { 
                anim.SetTrigger("Like");

            }
            else if (inputText.text == "ไม่ชอบ")
            { 
                anim.SetTrigger("Dislike");

            }
            else if (inputText.text == "โกรธ")
            { 
                anim.SetTrigger("Angry");

            }
            else if (inputText.text == "ดุ")
            { 
                anim.SetTrigger("Furious");

            }
            else if (inputText.text == "คิดถึง")
            { 
                anim.SetTrigger("Miss");

            }
            else if (inputText.text == "ฝัน")
            { 
                anim.SetTrigger("Dream");

            }
            else if (inputText.text == "ง่าย")
            { 
                anim.SetTrigger("Easy");

            }
            else if (inputText.text == "ยาก")
            { 
                anim.SetTrigger("Difficult");

            }
            else if (inputText.text == "จริง" || inputText.text == "แน่" || inputText.text == "แท้")
            { 
                anim.SetTrigger("True");

            }
            else if (inputText.text == "ไม่จริง")
            { 
                anim.SetTrigger("False");

            }
            else if (inputText.text == "ยิ้ม")
            { 
                anim.SetTrigger("Smile");

            }
            else if (inputText.text == "กล้า")
            { 
                anim.SetTrigger("Brave");

            }
            else if (inputText.text == "กลัว")
            { 
                anim.SetTrigger("Fearful");

            }
            else if (inputText.text == "ขยัน")
            { 
                anim.SetTrigger("Diligent");

            }
            else if (inputText.text == "ขี้เกียจ")
            { 
                anim.SetTrigger("Lazy");

            }
            else if (inputText.text == "อยาก")
            { 
                anim.SetTrigger("Want");

            }
            else if (inputText.text == "หิว")
            { 
                anim.SetTrigger("Hungry");

            }
            else if (inputText.text == "อิ่ม")
            { 
                anim.SetTrigger("Full");

            }
            else if (inputText.text == "จำ")
            { 
                anim.SetTrigger("Remember");

            }
            else if (inputText.text == "ลืม")
            { 
                anim.SetTrigger("Forget");

            }
            else if (inputText.text == "มีความสุข")
            { 
                anim.SetTrigger("Happy");

            }
            else if (inputText.text == "ใจร้อน")
            { 
                anim.SetTrigger("Impatient");

            }
            else if (inputText.text == "ใจเย็น")
            { 
                anim.SetTrigger("Calm");

            }
            else if (inputText.text == "ดีใจ")
            { 
                anim.SetTrigger("Pleased");

            }
            else if (inputText.text == "เสียใจ")
            { 
                anim.SetTrigger("Sad");

            }
            else if (inputText.text == "น้อยใจ")
            { 
                anim.SetTrigger("Disappointed");

            }
            else if (inputText.text == "ใจลอย")
            { 
                anim.SetTrigger("Indifferent");

            }
            else if (inputText.text == "สงสัย")
            { 
                anim.SetTrigger("Doubtful");

            }
            else if (inputText.text == "ไม่แน่ใจ")
            { 
                anim.SetTrigger("Uncertain");

            }
            else if (inputText.text == "มั่นใจ")
            { 
                anim.SetTrigger("Confident");

            }
            else if (inputText.text == "เบื่อ")
            { 
                anim.SetTrigger("Bored");

            }
            else if (inputText.text == "ทะเลาะ")
            { 
                anim.SetTrigger("Quarrel");

            }
            else if (inputText.text == "เสียดาย")
            { 
                anim.SetTrigger("Regretful");

            }
            else if (inputText.text == "ร้องไห้")
            { 
                anim.SetTrigger("Cry");

            }
            else if (inputText.text == "เศร้า" || inputText.text == "เสียใจ" || inputText.text == "เศร้าใจ")
            { 
                anim.SetTrigger("Sadness");

            }
            else if (inputText.text == "เหงา")
            { 
                anim.SetTrigger("Lonely");

            }
            else if (inputText.text == "รู้สึกโชคดี")
            { 
                anim.SetTrigger("GoodLuck");
            }

            else
            {
                messageText.gameObject.SetActive(true);

                anim.SetTrigger("Start");
            }

            yield return new WaitForSeconds(1.0f);
            
            anim.SetTrigger("Start");
            messageText.gameObject.SetActive(false);

            transform.position = new Vector3(1f, -99f, 184f);






        }
    }
}
