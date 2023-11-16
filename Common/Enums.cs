using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Common
{
    public enum Order
    {
        Popularity = 0,
        Trending,
        Alphabetical,
        ReleaseYear,
        TMDB_Popularity,
        IMDB_Score,
    }

    public enum Genre
    {
        All = 0,
        Crime,
        Fantasy,
        Musical,
        Romance,
        Action_N_Adventure,
        Sport,
        Western,
        Drama,
        RealityTv,
        European,
        Documentary,
        History,
        Thriller,
        SF,
        Horror,
        Military,
        Comedy,
        Kids_N_Family,
        Animation
    }

    public enum TitleType
    {
        All = 0,
        Movies,
        TvShows
    }

    public enum Country
    {
        AD, AE, AG, AL, AO, AR, AT, AU, AZ, BA, BB, BE, BF, BG, BH, BM,
        BO, BR, BS, BY, BZ, CA, CD, CH, CI, CL, CM, CO, CR, CU, CV, CY,
        CZ, DE, DK, DO, DZ, EC, EE, EG, ES, FI, FJ, FR, GF, GG, GH, GI,
        GQ, GR, GT, GY, HK, HN, HR, HU, ID, IE, IL, IN, IQ, IS, IT, JM,
        JO, JP, KE, KR, KW, LB, LC, LI, LT, LU, LV, LY, MA, MC, MD, ME,
        MG, MK, ML, MT, MU, MW, MX, MY, MZ, NE, NG, NI, NL, NO, NZ, OM,
        PA, PE, PF, PG, PH, PK, PL, PS, PT, PY, QA, RO, RS, RU, SA,
        SC, SE, SG, SI, SK, SM, SN, SV, TC, TD, TH, TN, TR, TT, TW, TZ,
        UA, UG, UK, US, UY, VA, VE, XK, YE, ZA, ZM, ZW
    }
    public enum Language
    {
        ar, az, be, bg, bs, ca, cs, de, el, en, es, et, fi, fr, he, hr, hu, @is, it, ja, lt, lv, mk, mt, pl, pt, ro, ru, sk, sl, sq, sr, sv, sw, tr, uk, ur, zh
    }
}
