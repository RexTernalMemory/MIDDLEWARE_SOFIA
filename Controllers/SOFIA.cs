using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SOFIA.Container;

namespace SOFIA.Controllers
{
    [Route("api/SOFIA")]
    [ApiController]
    public class SOFIA : Controller
    {
        private readonly ApplicationDBContext dbContext;
        public SOFIA(ApplicationDBContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpPost("RecieveDataFromNexus")]
        public async Task<IActionResult> AddData([FromBody] DataFromNexus DFN)
        {
            try
            {
                var Company = new SqlParameter("@ND_Company", DFN.Company);
                var BRANCH_NAME = new SqlParameter("@ND_BRANCH_NAME", DFN.BRANCH_NAME);
                var APPL_CRM_CODE = new SqlParameter("@ND_APPL_CRM_CODE", DFN.APPL_CRM_CODE);
                var LAST_NAME = new SqlParameter("@ND_LAST_NAME", DFN.LAST_NAME);
                var FIRST_NAME = new SqlParameter("@ND_FIRST_NAME", DFN.FIRST_NAME);
                var MIDDLE_NAME = new SqlParameter("@ND_MIDDLE_NAME", DFN.MIDDLE_NAME);
                var SUFFIX = new SqlParameter("@ND_SUFFIX", DFN.SUFFIX);
                var BIRTH_DATE = new SqlParameter("@ND_BIRTH_DATE", DFN.BIRTH_DATE);
                var APPL_AMOUNT_APPLIED = new SqlParameter("@ND_APPL_AMOUNT_APPLIED", DFN.APPL_AMOUNT_APPLIED);
                var APPL_TERMS_APPLIED = new SqlParameter("@ND_APPL_TERMS_APPLIED", DFN.APPL_TERMS_APPLIED);
                var APPL_DATE_APPLIED = new SqlParameter("@ND_APPL_DATE_APPLIED", DFN.APPL_DATE_APPLIED);
                var PRODUCT_NAME = new SqlParameter("@ND_PRODUCT_NAME", DFN.PRODUCT_NAME);
                var ADDRESS = new SqlParameter("@ND_ADDRESS", DFN.ADDRESS);
                var AREA = new SqlParameter("@ND_AREA", DFN.AREA);
                var LENGTH_STAY = new SqlParameter("@ND_LENGTH_STAY", DFN.LENGTH_STAY);
                var MOBILENO = new SqlParameter("@ND_MOBILENO", DFN.MOBILENO);
                var EMAIL = new SqlParameter("@ND_EMAIL", DFN.EMAIL);
                var AO_LAST_NAME = new SqlParameter("@ND_AO_LAST_NAME", DFN.AO_LAST_NAME);
                var AO_FIRST_NAME = new SqlParameter("@ND_AO_FIRST_NAME", DFN.AO_FIRST_NAME);
                var AO_MIDDLE_NAME = new SqlParameter("@ND_AO_MIDDLE_NAME", DFN.AO_MIDDLE_NAME);
                var AO_SUFFIX = new SqlParameter("@ND_AO_SUFFIX", DFN.AO_SUFFIX);
                var CREMAN_LAST_NAME = new SqlParameter("@ND_CREMAN_LAST_NAME", DFN.CREMAN_LAST_NAME);
                var CREMAN_FIRST_NAME = new SqlParameter("@ND_CREMAN_FIRST_NAME", DFN.CREMAN_FIRST_NAME);
                var CREMAN_MIDDLE_NAME = new SqlParameter("@ND_CREMAN_MIDDLE_NAME", DFN.CREMAN_MIDDLE_NAME);
                var CREMAN_SUFFIX = new SqlParameter("@ND_CREMAN_SUFFIX", DFN.CREMAN_SUFFIX);
                var MKTG_LAST_NAME = new SqlParameter("@ND_MKTG_LAST_NAME", DFN.MKTG_LAST_NAME);
                var MKTG_FIRST_NAME = new SqlParameter("@ND_MKTG_FIRST_NAME", DFN.MKTG_FIRST_NAME);
                var MKTG_MIDDLE_NAME = new SqlParameter("@ND_MKTG_MIDDLE_NAME", DFN.MKTG_MIDDLE_NAME);
                var MKTG_SUFFIX = new SqlParameter("@ND_MKTG_SUFFIX", DFN.MKTG_SUFFIX);
                var LOANS_LAST_NAME = new SqlParameter("@ND_LOANS_LAST_NAME", DFN.LOANS_LAST_NAME);
                var LOANS_FIRST_NAME = new SqlParameter("@ND_LOANS_FIRST_NAME", DFN.LOANS_FIRST_NAME);
                var LOANS_MIDDLE_NAME = new SqlParameter("@ND_LOANS_MIDDLE_NAME", DFN.LOANS_MIDDLE_NAME);
                var LOANS_SUFFIX = new SqlParameter("@ND_LOANS_SUFFIX", DFN.LOANS_SUFFIX);
                var APPL_AMOUNT_APPROVED = new SqlParameter("@ND_APPL_AMOUNT_APPROVED", DFN.APPL_AMOUNT_APPROVED);
                var APPL_TERMS_APPROVED = new SqlParameter("@ND_APPL_TERMS_APPROVED", DFN.APPL_TERMS_APPROVED);
                var APPL_AMOUNT_ACQUIRED = new SqlParameter("@ND_APPL_AMOUNT_ACQUIRED", DFN.APPL_AMOUNT_ACQUIRED);
                var APPL_AGENCY = new SqlParameter("@ND_APPL_AGENCY", DFN.APPL_AGENCY);
                var APPL_COUNTRY_DESTI = new SqlParameter("@ND_APPL_COUNTRY_DESTI", DFN.APPL_COUNTRY_DESTI);
                var APPL_TYPE = new SqlParameter("@ND_APPL_TYPE", DFN.APPL_TYPE);
                var BORR_CIVIL_STATUS = new SqlParameter("@ND_BORR_CIVIL_STATUS", DFN.BORR_CIVIL_STATUS);
                var BORR_GENDER = new SqlParameter("@ND_BORR_GENDER", DFN.BORR_GENDER);
                var BORR_EDUCATION = new SqlParameter("@ND_BORR_EDUCATION", DFN.BORR_EDUCATION);
                var BORR_COURSE = new SqlParameter("@ND_BORR_COURSE", DFN.BORR_COURSE);
                var BORR_LAST_SCHOOL = new SqlParameter("@ND_BORR_LAST_SCHOOL", DFN.BORR_LAST_SCHOOL);
                var AGNT_LASTNAME = new SqlParameter("@ND_AGNT_LASTNAME", DFN.AGNT_LASTNAME);
                var AGNT_FIRST_NAME = new SqlParameter("@ND_AGNT_FIRST_NAME", DFN.AGNT_FIRST_NAME);
                var AGNT_MIDDLENAME = new SqlParameter("@ND_AGNT_MIDDLENAME", DFN.AGNT_MIDDLENAME);
                var AGNT_SUFFIX = new SqlParameter("@ND_AGNT_SUFFIX", DFN.AGNT_SUFFIX);
                var AGNT_BIRTHDATE = new SqlParameter("@ND_AGNT_BIRTHDATE", DFN.AGNT_BIRTHDATE);
                var AGNT_MOBILENO = new SqlParameter("@ND_AGNT_MOBILENO", DFN.AGNT_MOBILENO);
                var AGNT_AGENT_REGDATE = new SqlParameter("@ND_AGNT_AGENT_REGDATE", DFN.AGNT_AGENT_REGDATE);
                var CoBORR1_LAST_NAME = new SqlParameter("@ND_CoBORR1_LAST_NAME", DFN.CoBORR1_LAST_NAME);
                var CoBORR1_FIRST_NAME = new SqlParameter("@ND_CoBORR1_FIRST_NAME", DFN.CoBORR1_FIRST_NAME);
                var CoBORR1_MIDDLE_NAME = new SqlParameter("@ND_CoBORR1_MIDDLE_NAME", DFN.CoBORR1_MIDDLE_NAME);
                var CoBORR1_SUFFIX = new SqlParameter("@ND_CoBORR1_SUFFIX", DFN.CoBORR1_SUFFIX);
                var CoBORR1_BIRTH_DATE = new SqlParameter("@ND_CoBORR1_BIRTH_DATE", DFN.CoBORR1_BIRTH_DATE);
                var CoBORR1_CIVIL_STATUS = new SqlParameter("@ND_CoBORR1_CIVIL_STATUS", DFN.CoBORR1_CIVIL_STATUS);
                var CoBORR1_GENDER = new SqlParameter("@ND_CoBORR1_GENDER", DFN.CoBORR1_GENDER);
                var CoBORR1_ADDRESS = new SqlParameter("@ND_CoBORR1_ADDRESS", DFN.CoBORR1_ADDRESS);
                var CoBORR1_LENGTH_STAY = new SqlParameter("@ND_CoBORR1_LENGTH_STAY", DFN.CoBORR1_LENGTH_STAY);
                var CoBORR1_TELNO = new SqlParameter("@ND_CoBORR1_TELNO", DFN.CoBORR1_TELNO);
                var CoBORR1_EMAIL = new SqlParameter("@ND_CoBORR1_EMAIL", DFN.CoBORR1_EMAIL);
                var SBOR_LAST_NAME = new SqlParameter("@ND_SBOR_LAST_NAME", DFN.SBOR_LAST_NAME);
                var SBOR_FIRST_NAME = new SqlParameter("@ND_SBOR_FIRST_NAME", DFN.SBOR_FIRST_NAME);
                var SBOR_MIDDLE_NAME = new SqlParameter("@ND_SBOR_MIDDLE_NAME", DFN.SBOR_MIDDLE_NAME);
                var SBOR_SUFFIX = new SqlParameter("@ND_SBOR_SUFFIX", DFN.SBOR_SUFFIX);
                var SBOR_GENDER = new SqlParameter("@ND_SBOR_GENDER", DFN.SBOR_GENDER);
                var SBOR_BIRTH_DATE = new SqlParameter("@ND_SBOR_BIRTH_DATE", DFN.SBOR_BIRTH_DATE);
                var SBOR_EDUCATION = new SqlParameter("@ND_SBOR_EDUCATION", DFN.SBOR_EDUCATION);
                var SBOR_COURSE = new SqlParameter("@ND_SBOR_COURSE", DFN.SBOR_COURSE);
                var SBOR_LAST_SCHOOL = new SqlParameter("@ND_SBOR_LAST_SCHOOL", DFN.SBOR_LAST_SCHOOL);
                await dbContext.Database.ExecuteSqlRawAsync("EXEC [dbo].[XTABLE_INSERT] " +
                 "@Company = @ND_Company," +
"@BRANCH_NAME = @ND_BRANCH_NAME," +
"@APPL_CRM_CODE = @ND_APPL_CRM_CODE," +
"@LAST_NAME = @ND_LAST_NAME," +
"@FIRST_NAME = @ND_FIRST_NAME," +
"@MIDDLE_NAME = @ND_MIDDLE_NAME," +
"@SUFFIX = @ND_SUFFIX," +
"@BIRTH_DATE = @ND_BIRTH_DATE," +
"@APPL_AMOUNT_APPLIED = @ND_APPL_AMOUNT_APPLIED," +
"@APPL_TERMS_APPLIED = @ND_APPL_TERMS_APPLIED," +
"@APPL_DATE_APPLIED = @ND_APPL_DATE_APPLIED," +
"@PRODUCT_NAME = @ND_PRODUCT_NAME," +
"@ADDRESS = @ND_ADDRESS," +
"@AREA = @ND_AREA," +
"@LENGTH_STAY = @ND_LENGTH_STAY," +
"@MOBILENO = @ND_MOBILENO," +
"@EMAIL = @ND_EMAIL," +
"@AO_LAST_NAME = @ND_AO_LAST_NAME," +
"@AO_FIRST_NAME = @ND_AO_FIRST_NAME," +
"@AO_MIDDLE_NAME = @ND_AO_MIDDLE_NAME," +
"@AO_SUFFIX = @ND_AO_SUFFIX," +
"@CREMAN_LAST_NAME = @ND_CREMAN_LAST_NAME," +
"@CREMAN_FIRST_NAME = @ND_CREMAN_FIRST_NAME," +
"@CREMAN_MIDDLE_NAME = @ND_CREMAN_MIDDLE_NAME," +
"@CREMAN_SUFFIX = @ND_CREMAN_SUFFIX," +
"@MKTG_LAST_NAME = @ND_MKTG_LAST_NAME," +
"@MKTG_FIRST_NAME = @ND_MKTG_FIRST_NAME," +
"@MKTG_MIDDLE_NAME = @ND_MKTG_MIDDLE_NAME," +
"@MKTG_SUFFIX = @ND_MKTG_SUFFIX," +
"@LOANS_LAST_NAME = @ND_LOANS_LAST_NAME," +
"@LOANS_FIRST_NAME = @ND_LOANS_FIRST_NAME," +
"@LOANS_MIDDLE_NAME = @ND_LOANS_MIDDLE_NAME," +
"@LOANS_SUFFIX = @ND_LOANS_SUFFIX," +
"@APPL_AMOUNT_APPROVED = @ND_APPL_AMOUNT_APPROVED," +
"@APPL_TERMS_APPROVED = @ND_APPL_TERMS_APPROVED," +
"@APPL_AMOUNT_ACQUIRED = @ND_APPL_AMOUNT_ACQUIRED," +
"@APPL_AGENCY = @ND_APPL_AGENCY," +
"@APPL_COUNTRY_DESTI = @ND_APPL_COUNTRY_DESTI," +
"@APPL_TYPE = @ND_APPL_TYPE," +
"@BORR_CIVIL_STATUS = @ND_BORR_CIVIL_STATUS," +
"@BORR_GENDER = @ND_BORR_GENDER," +
"@BORR_EDUCATION = @ND_BORR_EDUCATION," +
"@BORR_COURSE = @ND_BORR_COURSE," +
"@BORR_LAST_SCHOOL = @ND_BORR_LAST_SCHOOL," +
"@AGNT_LASTNAME = @ND_AGNT_LASTNAME," +
"@AGNT_FIRST_NAME = @ND_AGNT_FIRST_NAME," +
"@AGNT_MIDDLENAME = @ND_AGNT_MIDDLENAME," +
"@AGNT_SUFFIX = @ND_AGNT_SUFFIX," +
"@AGNT_BIRTHDATE = @ND_AGNT_BIRTHDATE," +
"@AGNT_MOBILENO = @ND_AGNT_MOBILENO," +
"@AGNT_AGENT_REGDATE = @ND_AGNT_AGENT_REGDATE," +
"@CoBORR1_LAST_NAME = @ND_CoBORR1_LAST_NAME," +
"@CoBORR1_FIRST_NAME = @ND_CoBORR1_FIRST_NAME," +
"@CoBORR1_MIDDLE_NAME = @ND_CoBORR1_MIDDLE_NAME," +
"@CoBORR1_SUFFIX = @ND_CoBORR1_SUFFIX," +
"@CoBORR1_BIRTH_DATE = @ND_CoBORR1_BIRTH_DATE," +
"@CoBORR1_CIVIL_STATUS = @ND_CoBORR1_CIVIL_STATUS," +
"@CoBORR1_GENDER = @ND_CoBORR1_GENDER," +
"@CoBORR1_ADDRESS = @ND_CoBORR1_ADDRESS," +
"@CoBORR1_LENGTH_STAY = @ND_CoBORR1_LENGTH_STAY," +
"@CoBORR1_TELNO = @ND_CoBORR1_TELNO," +
"@CoBORR1_EMAIL = @ND_CoBORR1_EMAIL," +
"@SBOR_LAST_NAME = @ND_SBOR_LAST_NAME," +
"@SBOR_FIRST_NAME = @ND_SBOR_FIRST_NAME," +
"@SBOR_MIDDLE_NAME = @ND_SBOR_MIDDLE_NAME," +
"@SBOR_SUFFIX = @ND_SBOR_SUFFIX," +
"@SBOR_GENDER = @ND_SBOR_GENDER," +
"@SBOR_BIRTH_DATE = @ND_SBOR_BIRTH_DATE," +
"@SBOR_EDUCATION = @ND_SBOR_EDUCATION," +
"@SBOR_COURSE = @ND_SBOR_COURSE," +
"@SBOR_LAST_SCHOOL = @ND_SBOR_LAST_SCHOOL",
Company,
BRANCH_NAME,
APPL_CRM_CODE,
LAST_NAME,
FIRST_NAME,
MIDDLE_NAME,
SUFFIX,
BIRTH_DATE,
APPL_AMOUNT_APPLIED,
APPL_TERMS_APPLIED,
APPL_DATE_APPLIED,
PRODUCT_NAME,
ADDRESS,
AREA,
LENGTH_STAY,
MOBILENO,
EMAIL,
AO_LAST_NAME,
AO_FIRST_NAME,
AO_MIDDLE_NAME,
AO_SUFFIX,
CREMAN_LAST_NAME,
CREMAN_FIRST_NAME,
CREMAN_MIDDLE_NAME,
CREMAN_SUFFIX,
MKTG_LAST_NAME,
MKTG_FIRST_NAME,
MKTG_MIDDLE_NAME,
MKTG_SUFFIX,
LOANS_LAST_NAME,
LOANS_FIRST_NAME,
LOANS_MIDDLE_NAME,
LOANS_SUFFIX,
APPL_AMOUNT_APPROVED,
APPL_TERMS_APPROVED,
APPL_AMOUNT_ACQUIRED,
APPL_AGENCY,
APPL_COUNTRY_DESTI,
APPL_TYPE,
BORR_CIVIL_STATUS,
BORR_GENDER,
BORR_EDUCATION,
BORR_COURSE,
BORR_LAST_SCHOOL,
AGNT_LASTNAME,
AGNT_FIRST_NAME,
AGNT_MIDDLENAME,
AGNT_SUFFIX,
AGNT_BIRTHDATE,
AGNT_MOBILENO,
AGNT_AGENT_REGDATE,
CoBORR1_LAST_NAME,
CoBORR1_FIRST_NAME,
CoBORR1_MIDDLE_NAME,
CoBORR1_SUFFIX,
CoBORR1_BIRTH_DATE,
CoBORR1_CIVIL_STATUS,
CoBORR1_GENDER,
CoBORR1_ADDRESS,
CoBORR1_LENGTH_STAY,
CoBORR1_TELNO,
CoBORR1_EMAIL,
SBOR_LAST_NAME,
SBOR_FIRST_NAME,
SBOR_MIDDLE_NAME,
SBOR_SUFFIX,
SBOR_GENDER,
SBOR_BIRTH_DATE,
SBOR_EDUCATION,
SBOR_COURSE,
SBOR_LAST_SCHOOL);

                return Ok(new
                {
                    status = "success",
                    message = "Info to Sofia",
                    description = "New data added.",
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return BadRequest(new
                {
                    status = "error",
                    message = "Something went wrong",
                    description = ex.Message
                });
            }
        }

        [HttpPost("TransferDataToNexus")]
        public async Task<IActionResult> TransferDataToNexus([FromBody] NexusLAN NL)
        {
            try
            {
                var DATA = await dbContext.DataFromSofia
                    .FromSqlRaw("EXEC [dbo].[XTABLE_GET] " + NL.LAN)
                    .ToListAsync();
                return Ok(DATA);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    status = "error",
                    message = "Something went wrong",
                    description = ex.Message
                });
            }
        }
    }
}
