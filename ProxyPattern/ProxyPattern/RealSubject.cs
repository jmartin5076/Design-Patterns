using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealSubject : Subject
    {
        public override void showComponent(string cell)
        {
            if (cell=="White Blood Cell")
            {
                Form2 f2 = new Form2();
                f2.m_tbDescription.Text = "White blood cells (WBCs), also called leukocytes or leucocytes, are the cells of the immune system that are involved in protecting the body against both infectious disease and foreign invaders. All white blood cells are produced and derived from multipotent cells in the bone marrow known as hematopoietic stem cells. Leukocytes are found throughout the body, including the blood and lymphatic system.";
                f2.Show();
            }
            else if (cell =="Red Blood Cell")
            {
                Form2 f2 = new Form2();
                f2.m_tbDescription.Text = "Red blood cells (RBCs), also called erythrocytes, are the most common type of blood cell and the vertebrate organism's principal means of delivering oxygen (O2) to the body tissues—via blood flow through the circulatory system.RBCs take up oxygen in the lungs or gills and release it into tissues while squeezing through the body's capillaries.";
                f2.Show();
            }
            else if (cell == "Mitochondria")
            {
                Form2 f2 = new Form2();
                f2.m_tbDescription.Text = "Mitochondria is the POWERHOUSE of the cell.";
                f2.Show();
            }
            else if (cell == "Nucleus")
            {
                Form2 f2 = new Form2();
                f2.m_tbDescription.Text = "In cell biology, the nucleus (pl. nuclei; from Latin nucleus or nuculeus, meaning kernel or seed) is a membrane-enclosed organelle found in eukaryotic cells. Eukaryotes usually have a single nucleus, but a few cell types, such as mammalian red blood cells, have no nuclei, and a few others have many.";
                f2.Show();
            }
            else if(cell=="Rough ER")
            {
                Form2 f2 = new Form2();
                f2.m_tbDescription.Text = "The surface of the rough endoplasmic reticulum (often abbreviated RER or Rough ER) (also called granular endoplasmic reticulum) is studded with protein-manufacturing ribosomes giving it a rough appearance (hence its name)";
                f2.Show();
            }
            else if(cell=="Smooth ER")
            {
                Form2 f2 = new Form2();
                f2.m_tbDescription.Text = "The smooth endoplasmic reticulum (abbreviated SER) has functions in several metabolic processes. It synthesizes lipids, phospholipids, and steroids. Cells which secrete these products, such as those in the testes, ovaries, and sebaceous glands have an abundance of smooth endoplasmic reticulum.";
                f2.Show();
            }
        }
    }
}
