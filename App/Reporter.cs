using System;
using System.Linq;
using System.Collections.Generic;
using CoreSchool.Entities;


namespace CoreSchool.App
{
    public  class Reporter
    {
        Dictionary<DictionaryKey, IEnumerable<ObjectSchoolBase>> _dictionary;//campos privados (convencion:"_" cuando se inicia un campo privado)
        public Reporter(Dictionary<DictionaryKey, IEnumerable<ObjectSchoolBase>> dicObjSch)
        {
            if (dicObjSch == null)
                throw new ArgumentNullException(nameof(dicObjSch));

            _dictionary = dicObjSch;
        }
        public IEnumerable<Evaluation> GetListEva()
        {
            if(_dictionary.TryGetValue(DictionaryKey.EVALUATION,  out IEnumerable<ObjectSchoolBase> list))
            {
                return  list.Cast<Evaluation>();
            }
            {
                return new List<Evaluation>();
            }
        }
        public IEnumerable<string> GetListSubject()
        {
            var listEva =  GetListEva();
            //va a guardar todo lo que traiga de Evaluation en ev
            return (from Evaluation ev in listEva
                    select ev.Subject.Name).Distinct();
        }
        public Dictionary<string, IEnumerable<Evaluation>> GetDicEvaXsub()
        {
            var dictaRta= new Dictionary<string, IEnumerable<Evaluation>> ();

            var listSub = GetListSubject();

            return dictaRta;
        }
    }
}