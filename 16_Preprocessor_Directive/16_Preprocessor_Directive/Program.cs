//#define은 심벌을 정의할 때 사용한다. 이렇게 정의된 심벌은 다른 전처리기 지시어에서 사용된다.
#define TEST_ENV
//#define PROD_ENV

#define STANDARD_EDITION
#define ENTERPRISE_EDITION

#undef ENTERPRISE_EDITION   //#undef는 심벌 해제

//경고, 에러 전처리기
//#warning은 경고 메시지 출력 후 계속 진행,
//#error은 에러 메시지 출력, 진행X
#if (STANDARD_EDITION && ENTERPRISE_EDITION)
#warning Use either STANDARD or ENTERPRISE edition. 
#error Use either STANDARD or ENTERPRISE edition. 
#endif

//pragma 전처리기 지시어
// 컴파일러 제작업체가 고유하게 자신들의 것을 만들어 사용 가능한 지시어
// MS의 C# 컴파일러는 pragma warning과 pragma checksum 2개를 지원한다.
// warning은 경고 매세지를 활성화, 비활성화 할 수 있으며 pragma checksum은 ASP.NET 페이지 디버깅에 주로 사용되며 ASPX 페이지의 파일 체크섬을 생성할 때 사용된다.
#pragma warning disable CS0266  //<-> #pragma warning restore CS0266

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Preprocessor_Directive
{
    /* 전처리기
     * 실제 컴파일이 시작되기 전에 컴파일러에게 특정 명령을 미리 처리하도록 지시하는 것. 
     * 모든 전처리기 지시어는 #으로 시작되며 ;를 붙이지 않는다.
     * 한 라인에 한 개의 전처리기 명령만을 사용한다.
     * 전처리기 지시어는 해당 파일 내에서만 효력을 발생한다. 
     * 하나의 클래스가 두 개의 파일에 나뉘어 Partial class로 저장되었을 때 동일한 심벌을 사용하고 싶다면 각각 정의해야 한다.
     * 
     * 자주 사용되는 전처리기 지시어로는 #define, #if, #else, #endif가 있다.
     * 흔히 #define과 #if를 결합하여 조건별로 서로 다른 코드 블럭을 커파일 가능하도록 한다.
     * 
     * Visual Studio에서는 조건별로 컴파일 되지 못하는 영역은 회색으로 표시된다.
     */

    class Program
    {
        //#region 전처리기 지시어는 #endregion과 쌍을 이루며 한 영역을 형성한다. 좌측의 +, -로 보여주거나 숨기기가 가능해져 복잡하고 긴 클래스들을 개념적으로 묶을 때 유용하다.
        #region Public Methods        
        public void Run() { }
        public void Create() { }
        #endregion

        #region Public Properties
        public int Id { get; set; }
        #endregion

        #region Privates
        private void Execute() { }
        #endregion

        static void Main(string[] args)
        {
            bool verbose = false;
            //# if, else endif 전처리기 지시어
#if (TEST_ENV)
            Console.WriteLine("Test Environment: Verbose option is set.");
            verbose = true;
#elif(PROD_ENV)
            Console.WriteLine("Production");
#else
            Console.WriteLine("undefined env");
#endif

            if (verbose)
            {
                Console.WriteLine("Test Logic run...");
                //int a = 1.21;
            }
        }
    }
}
